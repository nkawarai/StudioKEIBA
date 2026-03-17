using StudioKEIBA.Geography;

namespace StudioKEIBA.HorseProfilerApp.Views.Extensions
{

    static public class TrackEx
    {
        static public readonly string UNKNOWN = "";
        static public readonly string CHANGE_TRACK = "馬場替";
        static public readonly string SAME = "同距離";
        static public readonly string EXTENDED = "延長";
        static public readonly string SHORTENED = "短縮";

        /// <summary>
        /// 距離ローテを求める
        /// </summary>
        /// <param name="self">今回のトラック</param>
        /// <param name="prevTrack">前回のトラック</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        static internal string ResolveDistanceRotation(this ITrack self, ITrack prevTrack)
        {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }
            if (prevTrack == null)
            {
                throw new ArgumentNullException(nameof(prevTrack));
            }

            if (self.TrackType == TrackType.Unknown || prevTrack.TrackType == TrackType.Unknown
                || self.Distance == null || prevTrack.Distance == null)
            {
                //比較不能のため
                return UNKNOWN;
            }
            if (self.TrackType != prevTrack.TrackType)
            {
                return CHANGE_TRACK;
            }
            if (self.Distance.Meter < prevTrack.Distance.Meter)
            {
                return SHORTENED;
            }
            if (self.Distance.Meter > prevTrack.Distance.Meter)
            {
                return EXTENDED;
            }

            return SAME;
        }
    }
}
