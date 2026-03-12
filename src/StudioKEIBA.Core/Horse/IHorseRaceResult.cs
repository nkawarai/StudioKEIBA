namespace StudioKEIBA.Horse
{
    /// <summary>
    /// 競走馬のレース結果
    /// </summary>
    public interface IHorseRaceResult
    {
        /// <summary>
        /// レース情報
        /// </summary>
        IRace Race { get; }

        /// <summary>
        /// 枠番
        /// </summary>
        int Wakuban { get; }

        /// <summary>
        /// 馬番
        /// </summary>
        int Umaban { get; }

        /// <summary>
        /// オッズ
        /// </summary>
        double Odds { get; }

        /// <summary>
        /// 単勝人気
        /// </summary>
        int Popularity { get; }

        /// <summary>
        /// 着順
        /// </summary>
        int Rank { get; }

        /// <summary>
        /// 騎手
        /// </summary>
        string JockeyName { get; }

        /// <summary>
        /// 斤量
        /// </summary>
        double CarriedWeight { get; }

        /// <summary>
        /// 通過順位
        /// </summary>
        string PassingOrder { get; }

        /// <summary>
        /// あがり
        /// </summary>
        double AgariTime { get; }

        /// <summary>
        /// あがり順位
        /// </summary>
        int? AgariLank { get; }
               
        /// <summary>
        /// 馬体重
        /// </summary>
        IHorseWeight Weight { get; }
    }
}
