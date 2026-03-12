namespace StudioKEIBA
{
    internal class Distance : IDistance
    {
        private readonly double _meter;

        /// <summary>
        /// メートル
        /// </summary>
        public double Meter { get => _meter; }

        /// <summary>
        /// ハロン
        /// </summary>
        public double Furlong { get => _meter / 200.0; }

        public override string ToString()
            => Meter.ToString();

        /// <summary>
        /// ファクトリメソッド
        /// </summary>
        /// <param name="meter">距離[m]</param>
        /// <returns></returns>
        static internal IDistance CreateFromMeter(double meter)
            => new Distance(meter);

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        /// <param name="meter"></param>
        private Distance(double meter)
        {
            _meter = meter;
        }
    }
}
