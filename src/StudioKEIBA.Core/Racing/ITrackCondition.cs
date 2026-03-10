namespace StudioKEIBA
{
    /// <summary>
    /// 馬場状態
    /// </summary>
    public interface ITrackCondition
    {
        /// <summary>
        /// 状態名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 表示形態
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// 文字列表現
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
