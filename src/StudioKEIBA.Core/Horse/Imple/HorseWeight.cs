namespace StudioKEIBA.Horse.Imple
{
    /// <summary>
    /// 馬体重 実装クラス
    /// </summary>
    internal class HorseWeight : IHorseWeight
    {
        private int? _valueKg;
        private int _diffKg;

        /// <summary>
        /// 重さ[kg]
        /// </summary>
        public int? ValueKg { get => _valueKg; }

        /// <summary>
        /// 表示形式
        /// </summary>
        public string DisplayWeight
        {
            get
            {
                if (_valueKg == null) return "不明";
                return $"{ValueKg}({_diffKg.ToString("+#;-#;0")})";
            }
        }

        public override string ToString()
            => DisplayWeight;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal HorseWeight(int? valueKg, int diffKg = 0)
        {
            _valueKg = valueKg;
            _diffKg = diffKg;
        }
    }
}
