namespace StudioKEIBA.Racing
{
    /// <summary>
    /// 競走成績
    /// </summary>
    public interface IRaceStats
    {
        /// <summary>
        /// 合計
        /// </summary>
        int TotalCount { get; }

        /// <summary>
        /// 勝率
        /// </summary>
        double WinRate { get; }

        /// <summary>
        /// 複勝率
        /// </summary>
        double Top3Rate { get; }

        /// <summary>
        /// 表示文字列
        /// </summary>
        /// <returns></returns>
        string DisplayString();
    }
}
