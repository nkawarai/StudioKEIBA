using StudioKEIBA.Racing;

namespace StudioKEIBA.HorseProfilerApp.Views.ViewModels
{

    internal class RaceStatsViewModel
    {
        /// <summary>
        /// 急坂コースの成績
        /// </summary>
        public IRaceStats? SlopeStats { get; set; }

        /// <summary>
        /// 直線の長いコースの成績
        /// </summary>
        public IRaceStats? LongStraightStats { get; set; }

        /// <summary>
        /// 距離ローテが「同距離」時の成績
        /// </summary>
        public IRaceStats? SameDistanceRotationStats { get; set; } 

        /// <summary>
        /// 距離ローテが「短縮」時の成績
        /// </summary>
        public IRaceStats? ShortenedRotationStats { get; set; } 

        /// <summary>
        /// 距離ローテが「延長」時の成績
        /// </summary>
        public IRaceStats? ExtendedRotationStats { get; set; }

        /// <summary>
        /// 距離ローテが「馬場替わり」時の成績
        /// </summary>
        public IRaceStats? ChangeTrackStats { get; set; }
    }
}
