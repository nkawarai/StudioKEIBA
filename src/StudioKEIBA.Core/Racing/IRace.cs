namespace StudioKEIBA
{
    /// <summary>
    /// レース
    /// </summary>
    public interface IRace
    {
        /// <summary>
        /// 開催日
        /// </summary>
        DateOnly RaceDate { get; }

        /// <summary>
        /// トラック
        /// </summary>
        ITrack RaceTrack { get; }

        /// <summary>
        /// R番号
        /// </summary>
        int? RaceNumber { get; }

        /// <summary>
        /// レース名
        /// </summary>
        string RaceName { get; }

        /// <summary>
        /// レースページURL
        /// </summary>
        Uri RaceURL { get; }

        /// <summary>
        /// 出走馬数
        /// </summary>
        int HorseNum { get; }

        /// <summary>
        /// 馬場状態
        /// </summary>
        ITrackCondition TrackCondition { get; }

        /// <summary>
        /// 天候
        /// </summary>
        string Weather { get; }

        /// <summary>
        /// 前半3Fペース
        /// </summary>
        double? First3FTime { get; }

        /// <summary>
        /// 後半3Fペース
        /// </summary>
        double? Last3FTime { get; }
    }
}
