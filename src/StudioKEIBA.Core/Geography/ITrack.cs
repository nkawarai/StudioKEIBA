using StudioKEIBA.Geography;

namespace StudioKEIBA
{
    /// <summary>
    /// トラック
    /// </summary>
    public interface ITrack
    {
        /// <summary>
        /// 競馬場
        /// </summary>
        IRaceCourse RaceCourse { get; }

        /// <summary>
        /// 路盤
        /// </summary>
        TrackType TrackType { get; }

        /// <summary>
        /// 距離
        /// </summary>
        IDistance Distance { get; }

        /// <summary>
        /// 直線の長さ
        /// </summary>
        IDistance? StraightLength { get; }

        /// <summary>
        /// 直線急坂の有無
        /// </summary>
        bool? HasSlopeInStraight { get; }

        /// <summary>
        /// 小回りコースか
        /// </summary>
        bool? HasTightCorner { get; }
    }
}