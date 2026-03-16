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
        /// <remarks>海外のレースは枠番がない</remarks>
        int? Wakuban { get; }

        /// <summary>
        /// 馬番
        /// </summary>
        int Umaban { get; }

        /// <summary>
        /// オッズ
        /// </summary>
        double? Odds { get; }

        /// <summary>
        /// 単勝人気
        /// </summary>
        int? Popularity { get; }

        /// <summary>
        /// 着順
        /// </summary>
        IRank Rank { get; }

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
        /// <remarks>海外のレースはあがりがない場合がある</remarks>
        double? AgariTime { get; }

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
