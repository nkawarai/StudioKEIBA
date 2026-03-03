namespace StudioKEIBA.Netkeiba
{
    using Impl;

    /// <summary>
    /// ファクトリメソッド
    /// </summary>
    static public class AgentFactory
    {
        /// <summary>
        /// 競走馬ページのスクレイピングクライアントを作成する
        /// </summary>
        /// <returns></returns>
        static public IHorseScraper CreateHorseScraperAgent()
        {
            return new HorseScraperAgent();
        }
    }
}
