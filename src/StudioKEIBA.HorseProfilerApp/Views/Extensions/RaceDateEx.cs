namespace StudioKEIBA.HorseProfilerApp.Views.Extensions
{
    static public class RaceDateEx
    {
        static public readonly string UNKNOWN = "";
        static public readonly string CONSECUTIVE = "連闘";

        /// <summary>
        /// レース間隔を求める
        /// </summary>
        /// <param name="self">今回のレース日</param>
        /// <param name="prevDate">前走のレース日</param>
        /// <returns></returns>
        static internal string ResolveRaceInterval(this DateOnly self, DateOnly prevDate)
        {
            var days = self.DayNumber - prevDate.DayNumber;
            if (days <= 0) return UNKNOWN;
            if (days <= 7) return CONSECUTIVE;

            // 8日以降は「中○週」で表現
            var weeks = (days - 8) / 7 + 1;
            return $"中{weeks}週";
        }
    }
}
