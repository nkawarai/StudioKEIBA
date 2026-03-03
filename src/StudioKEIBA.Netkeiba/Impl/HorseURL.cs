namespace StudioKEIBA.Netkeiba.Impl
{
    /// <summary>
    /// netkeiba競走馬ページURL 実装クラス
    /// </summary>
    internal class HorseURL : IHorseURL
    {
        private Uri _url;

        /// <summary>
        /// URL
        /// </summary>
        public Uri URL { get => _url; }

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        /// <param name="horseID">netkeiba競走馬ID</param>
        internal HorseURL(IHorseID horseID)
        {
            _url = new Uri($"https://db.netkeiba.com/horse/{horseID}/");
        }
    }
}
