namespace StudioKEIBA.Horse.Imple
{
    internal class HorseRaceResult : IHorseRaceResult
    {
        /// <summary>
        /// レース情報
        /// </summary>
        public IRace Race { get; }

        /// <summary>
        /// 枠番
        /// </summary>
        public int? Wakuban { get; }

        /// <summary>
        /// 馬番
        /// </summary>
        public int Umaban { get; }

        /// <summary>
        /// オッズ
        /// </summary>
        public double? Odds { get; }

        /// <summary>
        /// 単勝人気
        /// </summary>
        public int? Popularity { get; }

        /// <summary>
        /// 着順
        /// </summary>
        public int Rank { get; }

        /// <summary>
        /// 騎手
        /// </summary>
        public string JockeyName { get; }

        /// <summary>
        /// 斤量
        /// </summary>
        public double CarriedWeight { get; }

        /// <summary>
        /// 通過順位
        /// </summary>
        public string PassingOrder { get; }

        /// <summary>
        /// あがり
        /// </summary>
        /// <remarks>海外のレースはあがりがない場合がある</remarks>
        public double? AgariTime { get; }

        /// <summary>
        /// あがり順位
        /// </summary>
        public int? AgariLank { get; }

        /// <summary>
        /// 馬体重
        /// </summary>
        public IHorseWeight Weight { get; }

        public override string ToString()
            => $"{Race} {Rank}着";

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        internal HorseRaceResult(IRace race, int? wakuban, int umaban, double odds, int populality,
            int rank, string jockeyName, double carriedWeight, string passingOrder,
            double? agariTime, int? agariLank, IHorseWeight horseWeight)
        {
            Race = race;
            Wakuban = wakuban;
            Umaban = umaban;
            Odds = odds;
            Popularity = populality;
            Rank = rank;
            JockeyName = jockeyName;
            CarriedWeight = carriedWeight;
            PassingOrder = passingOrder;
            AgariTime = agariTime;
            AgariLank = agariLank;
            Weight = horseWeight;                           
        }
    }
}
