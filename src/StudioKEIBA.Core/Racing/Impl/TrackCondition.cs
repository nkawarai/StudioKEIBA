namespace StudioKEIBA.Racing.Impl
{
    /// <summary>
    /// 馬場状態　実装クラス
    /// </summary>
    internal class TrackCondition : ITrackCondition
    {
        /// <summary>
        /// 状態名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 表示形態
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// 文字列表現
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => DisplayName;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal TrackCondition(string name, string displayName)
        {
            Name = name;
            DisplayName = displayName;
        }
    }
}
