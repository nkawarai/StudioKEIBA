using AngleSharp;
using System.Text;

namespace StudioKEIBA.Netkeiba.Impl
{
    internal class HorseScraperAgent : IHorseScraper
    {
        /// <summary>
        /// 競走馬プロフィールを取得する
        /// </summary>
        /// <param name="horseURL"></param>
        /// <returns></returns>
        async public Task<IHorseProfile> GetHorseProfile(IHorseURL horseURL)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(horseURL.URL.ToString());

            //馬名
            var horseTitleElement = document.QuerySelector(".horse_title h1");
            var horseName = horseTitleElement?.TextContent?.Trim() ?? string.Empty;

            var profile = HorseProfile.Create(horseName);
            return profile;
        }
    }
}
