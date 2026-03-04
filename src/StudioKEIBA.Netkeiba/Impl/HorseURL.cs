namespace StudioKEIBA.Netkeiba.Impl
{
    /// <summary>
    /// netkeiba競走馬ページURL 実装クラス
    /// </summary>
    internal class HorseURL : IHorseURL
    {
        private Uri _url;
        private IHorseID _horseID;

        /// <summary>
        /// URL
        /// </summary>
        public Uri URL { get => _url; }

        /// <summary>
        /// 競走馬ID
        /// </summary>
        public IHorseID ID { get => _horseID; }

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        /// <param name="horseID">netkeiba競走馬ID</param>
        internal HorseURL(IHorseID horseID)
        {
            _horseID = horseID;
            _url = new Uri($"https://db.netkeiba.com/horse/{horseID.Value}/");
        }
    }
}
