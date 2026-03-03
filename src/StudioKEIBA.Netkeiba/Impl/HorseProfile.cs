namespace StudioKEIBA.Netkeiba.Impl
{
    /// <summary>
    /// 競走馬プロフィール 実装クラス
    /// </summary>
    internal class HorseProfile : IHorseProfile
    {
        /// <summary>
        /// 馬名
        /// </summary>
        public string HorseName { get; }

        /// <summary>
        /// staticファクトリメソッド
        /// </summary>
        /// <returns></returns>
        static internal IHorseProfile Create(string horseName)
            => new HorseProfile(horseName);

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        private HorseProfile(string horseName)
        {
            HorseName = horseName;
        }
    }
}
