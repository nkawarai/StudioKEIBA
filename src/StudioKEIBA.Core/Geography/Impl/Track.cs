namespace StudioKEIBA.Geography.Impl
{
    internal class Track : ITrack
    {
        /// <summary>
        /// 競馬場
        /// </summary>
        public IRaceCourse RaceCourse { get; }

        /// <summary>
        /// 路盤
        /// </summary>
        public TrackType TrackType { get; }

        /// <summary>
        /// 距離
        /// </summary>
        public IDistance Distance { get; }

        /// <summary>
        /// 直線の長さ
        /// </summary>
        public IDistance? StraightLength { get; }

        /// <summary>
        /// 直線急坂の有無
        /// </summary>
        public bool? HasSlopeInStraight { get; }

        /// <summary>
        /// 小回りコースか
        /// </summary>
        public bool? HasTightCorner { get; }

        /// <summary>
        /// ファクトリメソッド
        /// </summary>
        /// <returns></returns>
        static public ITrack Create(IRaceCourse raceCourse, TrackType trackType, IDistance distance,
            IDistance? straightDistance, bool? hasSlope, bool? hasTightCorner)
            => new Track(raceCourse, trackType, distance, straightDistance, hasSlope, hasTightCorner);

        public override string ToString()
            => $"{RaceCourse.DisplayName} {TrackType}{Distance.Meter}m";


        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        private Track(IRaceCourse raceCourse, TrackType trackType, IDistance distance,
            IDistance? straightDistance, bool? hasSlope, bool? hasTightCorner)
        {
            RaceCourse = raceCourse;
            TrackType = trackType;
            Distance = distance;
            StraightLength = straightDistance;
            HasSlopeInStraight = hasSlope;
            HasTightCorner = hasTightCorner;
        }
    }
}
