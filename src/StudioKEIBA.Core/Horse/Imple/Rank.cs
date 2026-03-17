namespace StudioKEIBA.Horse.Imple
{
    internal class Rank : IRank
    {
        private int? _rank;
        private string? _irregularResult;

        public override string ToString()
        {
            if (_rank != null) return _rank.ToString()!;
            return _irregularResult ?? string.Empty;
        }

        /// <summary>
        /// int型に変換する
        /// </summary>
        /// <returns></returns>
        /// <remarks>競争中止や出走取消の場合はnullを返す</remarks>
        public int? ToInt()
            => _rank;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal Rank(string rankStr)
        {
            if (int.TryParse(rankStr, out var value))
            {
                _rank = value;
            }
            else
            {
                _irregularResult = rankStr;
            }
        }
    }
}
