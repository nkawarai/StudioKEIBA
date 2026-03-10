using StudioKEIBA.Horse;

namespace StudioKEIBA.Netkeiba
{
    public interface IHorseScraper
    {
        /// <summary>
        /// 競走馬名を取得する
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        Task<string> GetHorseName(IHorseURL horseURL);

        /// <summary>
        /// 血統を取得する
        /// </summary>
        /// <param name="horseURL"></param>
        /// <returns></returns>
        Task<IPedigree> GetPedigree(IHorseURL horseURL);

        /// <summary>
        /// レース戦歴を取得する
        /// </summary>
        /// <param name="horseURL"></param>
        /// <returns></returns>
        Task<IEnumerable<IHorseRaceResult>> GetRaceResults(IHorseURL horseURL);
    }
}
