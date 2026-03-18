using StudioKEIBA.Racing;

namespace StudioKEIBA.HorseProfilerApp.Views.ViewModels
{
    public interface IRaceStasViewModel
    {

        /// <summary>
        /// 項目名
        /// </summary>
        string ItemName { get; }

        /// <summary>
        /// 合計
        /// </summary>
        int TotalCount { get; }

        /// <summary>
        /// 勝率
        /// </summary>
        double WinRate { get; }

        /// <summary>
        /// 複勝率
        /// </summary>
        double Top3Rate { get; }

        /// <summary>
        /// 表示文字列
        /// </summary>
        /// <returns></returns>
        string StatsString { get; }
    }
    
    /// <summary>
    /// カテゴリー別成績ViewModel
    /// </summary>
    public class RaceStatsViewModel : IRaceStasViewModel
    {
        private string _displayString;

        /// <summary>
        /// 項目名
        /// </summary>
        public string ItemName { get; }

        /// <summary>
        /// 合計
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        /// 勝率
        /// </summary>
        public double WinRate { get; }

        /// <summary>
        /// 複勝率
        /// </summary>
        public double Top3Rate { get; }

        /// <summary>
        /// 表示文字列
        /// </summary>
        /// <returns></returns>
        public string StatsString => _displayString;

        public string DisplayString() => _displayString;

        public override string ToString() => $"{ItemName} {_displayString}";

        /// <summary>
        /// ファクトリメソッド
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="raceStats"></param>
        /// <returns></returns>
        static public IRaceStasViewModel Create(string itemName, IRaceStats raceStats)
            => new RaceStatsViewModel(itemName, raceStats);

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        private RaceStatsViewModel(string itemName, IRaceStats raceStats)
        {
            ItemName = itemName;
            TotalCount = raceStats.TotalCount;
            WinRate = raceStats.WinRate;
            Top3Rate = raceStats.Top3Rate;
            _displayString = raceStats.DisplayString();
        }
    }
}
