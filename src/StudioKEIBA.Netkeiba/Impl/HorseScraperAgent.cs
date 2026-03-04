using AngleSharp;
using AngleSharp.Html.Parser;
using System.Text;
using System.Text.Json;

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

            return Factory.CreatePedigree(fatherName, motherFatherName);
        }
    }
}
