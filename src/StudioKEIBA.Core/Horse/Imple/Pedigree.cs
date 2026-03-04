namespace StudioKEIBA
{
    /// <summary>
    /// 血統　実測クラス
    /// </summary>
    internal class Pedigree : IPedigree
    {
        /// <summary>
        /// 父
        /// </summary>
        public IStallion Father { get; }

        /// <summary>
        /// 母父
        /// </summary>
        public IStallion MotherFather { get; }

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        internal Pedigree(IStallion father, IStallion motherFather)
        {
            Father = father;
            MotherFather = motherFather; 
        }
    }
}
