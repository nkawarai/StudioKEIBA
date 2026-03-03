namespace StudioKEIBA.Netkeiba.Impl
{
    /// <summary>
    /// netkeiba HorseID
    /// </summary>
    internal class HorseID : IHorseID
    {
        private const int ID_LENGTH = 10;
        private string _id;

        /// <summary>
        /// ID
        /// </summary>
        public string Value { get => _id; }


        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        internal HorseID(string id)
        {
            if (id.Length != ID_LENGTH || !uint.TryParse(id, out var _))
            {
                throw new ArgumentException("Invalid HorseID was speficied.");
            }
            _id = id;
        }
    }
}
