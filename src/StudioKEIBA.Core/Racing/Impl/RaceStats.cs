namespace StudioKEIBA.Racing.Impl
{
    internal class RaceStats : IRaceStats
    {
        private int _1stCount;
        private int _2ndCount;
        private int _3rdCount;
        private int _otherCount;

        /// <summary>
        /// 合計
        /// </summary>
        public int TotalCount
            => _1stCount + _2ndCount + _3rdCount + _otherCount;

        /// <summary>
        /// 勝率
        /// </summary>
        public double WinRate
            => TotalCount == 0 ? 0 : (double)_1stCount / TotalCount;

        /// <summary>
        /// 複勝率
        /// </summary>
        public double Top3Rate
            => TotalCount == 0 ? 0 : (double)(_1stCount + _2ndCount + _3rdCount) / TotalCount;

        /// <summary>
        /// 表示文字列
        /// </summary>
        /// <returns></returns> 
        public string DisplayString() => $"{_1stCount}-{_2ndCount}-{_3rdCount}-{_otherCount}";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal RaceStats(int first, int second, int third, int other)
        {
            _1stCount = first;
            _2ndCount = second;
            _3rdCount = third;
            _otherCount = other;
        }
    }
}
