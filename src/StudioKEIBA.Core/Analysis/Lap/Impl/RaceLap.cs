
namespace StudioKEIBA.Analysis.Lap.Impl
{
    /// <summary>
    /// レースラップ実装クラス
    /// </summary>
    internal class RaceLap : IRaceLap
    {
        private int _lapDistanceMeter = 200;
        private readonly double _lapLowerLimit = 9.0;
        private IEnumerable<double> _raceLap;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RaceLap(IEnumerable<double> racelap)
        {
            _raceLap = racelap;
        }

        /// <summary>
        /// 距離を取得する
        /// </summary>
        /// <returns></returns>
        public int Distance()
        {
            var meter = _raceLap.Count() * _lapDistanceMeter;
            if (_raceLap.Count() > 0 && _raceLap.ElementAt(0) < _lapLowerLimit)
            {
                //最初のラップが基準値以下の場合は100m短縮とみなす
                meter -= 100;
            }

            return meter;
        }

        /// <summary>
        /// 走破タイム秒を取得する
        /// </summary>
        /// <returns></returns>
        public double TotalSecond()
            => _raceLap.Sum();

        /// <summary>
        /// 走破タイムを取得する
        /// </summary>
        /// <returns></returns>
        public string TotalTime()
        {
            var totalSecond = this.TotalSecond();
            var minute = (int)(totalSecond / 60);
            var second = totalSecond % 60;
            return $"{minute}.{second.ToString("F1")}";
        }

        /// <summary>
        /// 経過ラップを取得する
        /// </summary>
        /// <returns></returns>
        public IEnumerable<double> ElaspeLap()
        {
            var elaspedLap = new List<double>();
            double elasped = 0;
            foreach (var lap in _raceLap)
            {
                elasped += lap;
                elaspedLap.Add(elasped);
            }
            return elaspedLap;
        }

        /// <summary>
        /// 逆ラップを取得する
        /// </summary>
        /// <returns></returns>
        public IEnumerable<double> ReverseLap()
        {
            var revs = _raceLap.Reverse();
            var reversedLap = new List<double>();
            double reversed = 0;
            foreach (var lap in revs)
            {
                reversed += lap;
                reversedLap.Add(reversed);
            }
            reversedLap.Reverse();
            return reversedLap;
        }


        /// <summary>
        /// テン600mのタイム
        /// </summary>
        /// <returns></returns>
        public double First600m()
        {
            if (_raceLap.Count() < 3)
            {
                return 0;
            }

            return _raceLap.Take(3).Sum();
        }

        /// <summary>
        /// あがり600mのタイム
        /// </summary>
        /// <returns></returns>
        public double Last600m()
        {
            if (_raceLap.Count() < 3)
            {
                return 0;
            }

            return _raceLap.Skip(_raceLap.Count() - 3).Sum();
        }

        /// <summary>
        /// 平均ラップ
        /// </summary>
        /// <returns></returns>
        public double LapAverage()
            => _raceLap.Average();

        /// <summary>
        /// ラスト5Fの標準偏差
        /// </summary>
        /// <returns></returns>
        public double StandardDeviationOfLast5F()
        {
            if (_raceLap.Count() < 5) return 0;
            var targetLap = _raceLap.Skip(_raceLap.Count() - 5);

            var ave = targetLap.Average();
            return Math.Sqrt(targetLap.Sum(x => Math.Pow(x - ave, 2)));
        }

    }
}
