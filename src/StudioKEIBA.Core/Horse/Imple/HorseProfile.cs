namespace StudioKEIBA.Horse.Imple
{
    /// <summary>
    /// 競走馬プロフィール
    /// </summary>
    internal class HorseProfile : IHorseProfile
    {
        /// <summary>
        /// 競走馬馬名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 血統
        /// </summary>
        public IPedigree Pedigree { get; }

        /// <summary>
        /// 戦歴
        /// </summary>
        public IEnumerable<IHorseRaceResult> HorseRaceResults { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal HorseProfile(string name, IPedigree pedigree, IEnumerable<IHorseRaceResult> horseRaceResults)
        {
            Name = name;
            Pedigree = pedigree;
            HorseRaceResults = horseRaceResults;
        }
    }
}
