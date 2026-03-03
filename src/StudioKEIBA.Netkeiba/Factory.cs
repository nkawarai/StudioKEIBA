namespace StudioKEIBA.Netkeiba
{
    using Impl;

    /// <summary>
    /// ファクトリメソッド
    /// </summary>
    static public class Factory
    {
        /// <summary>
        /// 競走馬ページのスクレイピングクライアントを作成する
        /// </summary>
        /// <returns></returns>
        static public IHorseScraper CreateHorseScraperClient()
        {
            return new HorseScraperClient();
        }
    }
}
