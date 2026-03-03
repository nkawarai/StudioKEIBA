namespace StudioKEIBA.Netkeiba
{
    public interface IHorseScraper
    {
        /// <summary>
        /// 競走馬プロフィールを取得する
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        Task<IHorseProfile> GetHorseProfile(IHorseURL horseURL);
    }
}
