using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using StudioKEIBA.Geography;
using StudioKEIBA.Horse;
using StudioKEIBA.Racing;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace StudioKEIBA.Netkeiba.Impl
{
    internal class HorseScraperAgent : IHorseScraper
    {
        /// <summary>
        /// 競走馬名を取得する
        /// </summary>
        /// <param name="horseURL"></param>
        /// <returns></returns>
        async public Task<string> GetHorseName(IHorseID horseID)
        {
            var horseURL = ValueObjectFactory.CreateHorseURL(horseID);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(horseURL.URL.ToString());

            var horseTitleElement = document.QuerySelector(".horse_title h1");
            var horseName = horseTitleElement?.TextContent?.Trim() ?? string.Empty;

            return horseName;
        }

        /// <summary>
        /// 血統を取得する
        /// </summary>
        /// <param name="horseURL"></param>
        /// <returns></returns>
        async public Task<IPedigree> GetPedigree(IHorseID horseID)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            //血統はajaxで取得する必要があるため、APIを叩いてHTMLフラグメントを取得する
            using var httpClient = new HttpClient();
            var horsePedigreeUrl = $"https://db.netkeiba.com/horse/ajax_horse_pedigree.html"
                       + $"?input=UTF-8&output=json&id={horseID.Value}";

            var horsePedigreeJson = await httpClient.GetStringAsync(horsePedigreeUrl);
            using var jsonDoc = JsonDocument.Parse(horsePedigreeJson);
            var htmlFragment = jsonDoc.RootElement.GetProperty("data").GetString();

            var parser = context.GetService<IHtmlParser>();
            if (parser == null) throw new InvalidOperationException("IHtmlParser service is not available in the browsing context.");
            var fragment = await parser.ParseDocumentAsync(htmlFragment ?? string.Empty);

            var rows = fragment.QuerySelectorAll(".blood_table tr");
            var fatherName = rows.Length > 0
                ? rows[0].QuerySelector("td.b_ml[rowspan='2']")
                    ?.QuerySelector("span")?.TextContent?.Trim() ?? string.Empty
                : string.Empty;

            var motherFatherName = rows.Length > 2
                ? rows[2].QuerySelector("td.b_ml")
                    ?.QuerySelector("span")?.TextContent?.Trim() ?? string.Empty
                : string.Empty;

            return HorseFactory.CreatePedigree(fatherName, motherFatherName);
        }

        /// <summary>
        /// レース戦歴を取得する
        /// </summary>
        /// <param name="horseURL"></param>
        /// <returns></returns>
        async public Task<IEnumerable<IHorseRaceResult>> GetRaceResults(IHorseID horseID)
        {
            var results = new List<IHorseRaceResult>(); // 戻り値

            using var httpClient = new HttpClient();
            var apiUrl = $"https://db.netkeiba.com/horse/ajax_horse_results.html"
                       + $"?input=UTF-8&output=json&id={horseID.Value}";
            var json = await httpClient.GetStringAsync(apiUrl);

            using var jsonDoc = JsonDocument.Parse(json);
            var status = jsonDoc.RootElement.GetProperty("status").GetString();
            if (status != "OK") return results;

            var htmlFragment = jsonDoc.RootElement.GetProperty("data").GetString();

            var config = Configuration.Default;
            var context = BrowsingContext.New(config);
            var parser = context.GetService<IHtmlParser>();
            if (parser == null) throw new ApplicationException(nameof(parser));
            var fragment = await parser.ParseDocumentAsync(htmlFragment ?? string.Empty);
            var rows = fragment.QuerySelectorAll(".db_h_race_results tbody tr");

            foreach (var row in rows)
            {
                var cells = row.QuerySelectorAll("td");
                if (cells.Length < 25) continue;

                #region ---- private method ----
                string Text(int i) => cells[i].TextContent.Trim();

                int Int(int i) => int.Parse(Text(i));

                double Double(int i) => double.Parse(Text(i));

                string ParseVenue(string raw)
                    => Regex.Replace(raw, @"^\d+|\d+$", "");

                string GetRaceUrl(IElement cell)
                    => cell.QuerySelector("a")?.GetAttribute("href") ?? string.Empty;

                (double First, double Last) ParsePace(string raw)
                {
                    var parts = raw.Split('-');
                    if (parts.Length != 2)
                    {
                        throw new InvalidDataException($"レースペースを表す文字列をレースペース値に変換できません。\n文字列:{raw}");
                    }
                    double first = double.Parse(parts[0]);
                    double last = double.Parse(parts[1]);
                    return (first, last);
                }

                int? GetLastSpurtRank(IElement cell)
                {
                    var classes = cell.ClassList;
                    if (classes.Contains("rank_1")) return 1;
                    if (classes.Contains("rank_2")) return 2;
                    if (classes.Contains("rank_3")) return 3;
                    return null;
                }
                #endregion

                //コース
                var raceCourseName = ParseVenue(Text(1));
                var distanceString = Text(14);
                var trackType = TrackTypeFactory.CreateFromString(distanceString.Substring(0, 1));
                var distance = int.Parse(distanceString.Substring(1));
                var track = TrackCatalog.FindOrCreate(raceCourseName, trackType, distance);

                //レース
                var raceDate = DateTime.Parse(Text(0));
                var raceNumber = Int(3);
                var raceName = Text(4);
                var raceUri = new Uri(GetRaceUrl(cells[4]));
                int horseNum = Int(6);
                var trackCondition = TrackConditionCatalog.FindOrCreate(Text(16));
                var weather = Text(2);
                var pace = ParsePace(Text(22));
                var first3F = pace.First;
                var last3F = pace.Last;                    
                var race = RaceFactory.Create(raceDate, track, raceNumber, raceName, raceUri, horseNum, trackCondition, weather, first3F, last3F);

                //競走馬のレース結果
                var wakuban = Int(7);
                var umaban = Int(8);
                var odds = Double(9);
                var popularity = Int(10);
                var rank = Int(11);
                var jockeyName = Text(12);
                var carriedWeight = Double(13);
                var passingOrder = Text(21);
                var agariTime = Double(23);
                var agariLank = GetLastSpurtRank(cells[23]);
                var horseWeight = HorseFactory.CreateHorseWeight(Text(24));
                var horseRaceResult = HorseFactory.CreateHorseRaceResult(race, wakuban, umaban, odds, popularity, rank, jockeyName,
                    carriedWeight, passingOrder, agariTime, agariLank, horseWeight);
                results.Add(horseRaceResult);

            }
            return results;
        }
    }
}
