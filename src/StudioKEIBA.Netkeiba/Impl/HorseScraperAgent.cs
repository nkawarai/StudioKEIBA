using AngleSharp;
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
        async public Task<string> GetHorseName(IHorseURL horseURL)
        {
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
        async public Task<IPedigree> GetPedigree(IHorseURL horseURL)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            //血統はajaxで取得する必要があるため、APIを叩いてHTMLフラグメントを取得する
            using var httpClient = new HttpClient();
            var horsePedigreeUrl = $"https://db.netkeiba.com/horse/ajax_horse_pedigree.html"
                       + $"?input=UTF-8&output=json&id={horseURL.ID.Value}";

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
        async public Task<IEnumerable<IHorseRaceResult>> GetRaceResults(IHorseURL horseURL)
        {
            var results = new List<IHorseRaceResult>();
            using var httpClient = new HttpClient();
            var apiUrl = $"https://db.netkeiba.com/horse/ajax_horse_results.html"
                       + $"?input=UTF-8&output=json&id={horseURL.ID.Value}";
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

                //コース
                var raceCourseName = Regex.Replace(cells[1].TextContent.Trim(), @"^\d+|\d+$", "");
                var distanceString = cells[14].TextContent.Trim();
                var trackType = TrackTypeFactory.CreateFromString(distanceString.Substring(0, 1));
                var distance = int.Parse(distanceString.Substring(1));
                var track = TrackCatalog.Find(raceCourseName, trackType, distance);

                //レース
                var raceDate = DateTime.Parse(cells[0].TextContent.Trim());
                var raceNumber = int.Parse(cells[3].TextContent.Trim());
                var raceName = cells[4].TextContent.Trim();
                int horseNum = int.Parse(cells[6].TextContent.Trim());
                var trackCondition = TrackConditionCatalog.Find(cells[16].TextContent.Trim());
                var weather = cells[2].TextContent.Trim();
                var racePace = cells[22].TextContent.Trim().Split('-');
                if (racePace == null || racePace.Length != 2) throw new FormatException(nameof(racePace));
                var first3F = double.Parse(racePace[0]);
                var last3F = double.Parse(racePace[1]);                    
                var race = RaceFactory.Create(raceDate, track, raceNumber, raceName, horseNum, trackCondition,
                    weather, first3F, last3F);

                //var result = HorseFactory.CreateHorseRaceResult();

                //results.Add(new RaceResult(
                //    Date: Text(0),
                //    Venue: Text(1),
                //    Weather: Text(2),
                //    RaceNumber: Text(3),
                //    RaceName: Text(4),
                //    HorseCount: Text(6),   // 5は映像列のためスキップ
                //    FrameNumber: Text(7),
                //    HorseNumber: Text(8),
                //    Odds: Text(9),
                //    Popularity: Text(10),
                //    Rank: Text(11),
                //    Jockey: Text(12),
                //    Weight: Text(13),
                //    Distance: Text(14),
                //    TrackCondition: Text(16),  // 15は水分量(非表示)のためスキップ
                //    PassingOrder: Text(21),
                //    Pace: Text(22),
                //    LastSpurt: Text(23),
                //    HorseWeight: Text(24)
                //));
            }
            return null; //仮
        }
    }
}
