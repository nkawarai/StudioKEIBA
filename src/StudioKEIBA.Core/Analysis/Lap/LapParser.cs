namespace StudioKEIBA.Analysis
{
    /// <summary>
    /// ラップパーサー
    /// </summary>
    static public class LapParser
    {
        /// <summary>
        /// ラップ文字列をパースする
        /// </summary>
        /// <param name="lap"></param>
        /// <returns></returns>
        static public List<double> Parse(string lap)
        {
            var laps = new List<double>();
            if (string.IsNullOrWhiteSpace(lap))
            {
                return laps;
            }
            var lstrs = lap.Replace(" ", "").Split('-').ToList();

            lstrs.ForEach(x =>
            {
                if (!double.TryParse(x, out var value))
                {
                    throw new FormatException("Lap string contains invalid string.");
                }
                laps.Add(value);
            });

            return laps;
        }

        /// <summary>
        /// ラップリストを文字列形式に変換する
        /// </summary>
        /// <param name="lapList"></param>
        /// <param name="spaceInsert"></param>
        /// <returns></returns>
        static public string LapToString(IEnumerable<double> lapList, bool spaceInsert = true)
        {
            var lapStr = string.Join(" - ", lapList.Select(x => x.ToString("F1")));
            if (!spaceInsert)
            {
                lapStr = lapStr.Replace(" ", "");
            }
            return lapStr;
        }
    }
}
