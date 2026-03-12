namespace StudioKEIBA
{
    /// <summary>
    /// 種牡馬 実装クラス
    /// </summary>
    internal class Stallion : IStallion
    {
        /// <summary>
        /// 種牡馬名
        /// </summary>
        public string HorseName { get; }

        public override string ToString()
            => HorseName;

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        /// <param name="horseName"></param>
        internal Stallion(string horseName)
        {
            HorseName = horseName;
        }
    }
}
