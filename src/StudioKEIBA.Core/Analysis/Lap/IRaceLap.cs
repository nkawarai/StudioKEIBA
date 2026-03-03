namespace StudioKEIBA.Analysis
{
    /// <summary>
    /// レースラップ
    /// </summary>
    public interface IRaceLap
    {
        /// <summary>
        /// 距離を取得する
        /// </summary>
        /// <returns></returns>
        int Distance();

        /// <summary>
        /// 走破タイム秒を取得する
        /// </summary>
        /// <returns></returns>
        double TotalSecond();

        /// <summary>
        /// 走破タイムを取得する
        /// </summary>
        /// <returns></returns>
        string TotalTime();

        /// <summary>
        /// 経過ラップを取得する
        /// </summary>
        /// <returns></returns>
        IEnumerable<double> ElaspeLap();

        /// <summary>
        /// 逆ラップを取得する
        /// </summary>
        /// <returns></returns>
        IEnumerable<double> ReverseLap();

        /// <summary>
        /// テン600mのタイム
        /// </summary>
        /// <returns></returns>
        double First600m();

        /// <summary>
        /// あがり600mのタイム
        /// </summary>
        /// <returns></returns>
        double Last600m();

        /// <summary>
        /// 平均ラップ
        /// </summary>
        /// <returns></returns>
        double LapAverage();

        /// <summary>
        /// ラスト5Fの標準偏差
        /// </summary>
        /// <returns></returns>
        double StandardDeviationOfLast5F();
    }
}
