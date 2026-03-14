namespace StudioKEIBA.Racing.Impl
{
    internal class Race : IRace
    {
        /// <summary>
        /// 開催日
        /// </summary>
        public DateTime RaceDate { get; }

        /// <summary>
        /// トラック
        /// </summary>
        public ITrack RaceTrack { get; }

        /// <summary>
        /// R番号
        /// </summary>
        public int? RaceNumber { get; }

        /// <summary>
        /// レース名
        /// </summary>
        public string RaceName { get; }

        /// <summary>
        /// レースページURL
        /// </summary>
        public Uri RaceURL { get; }

        /// <summary>
        /// 出走馬数
        /// </summary>
        public int HorseNum { get; }

        /// <summary>
        /// 馬場状態
        /// </summary>
        public ITrackCondition TrackCondition { get; }

        /// <summary>
        /// 天候
        /// </summary>
        public string Weather { get; }

        /// <summary>
        /// 前半3Fペース
        /// </summary>
        public double? First3FTime { get; }

        /// <summary>
        /// 後半3Fペース
        /// </summary>
        public double? Last3FTime { get; }

        public override string ToString()
            => RaceName;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal Race(DateTime raceDate, ITrack raceTrack, int? raceNumber, string raceName, Uri raceUri, int horseNum,
            ITrackCondition condition, string weather, double? first3F, double? last3F)
        {
             RaceDate = raceDate;
            RaceTrack = raceTrack;
            RaceNumber = raceNumber;
            RaceName = raceName;
            RaceURL = raceUri;
            HorseNum = horseNum;
            TrackCondition = condition;
            Weather = weather;
            First3FTime = first3F;
            Last3FTime = last3F;
        }
    }
}
