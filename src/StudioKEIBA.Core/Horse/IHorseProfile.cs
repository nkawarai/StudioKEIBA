namespace StudioKEIBA.Horse
{
    /// <summary>
    /// 競走馬プロフィール
    /// </summary>
    public interface IHorseProfile
    {
        /// <summary>
        /// 競走馬馬名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 血統
        /// </summary>
        IPedigree Pedigree { get; }

        /// <summary>
        /// 戦歴
        /// </summary>
        IEnumerable<IHorseRaceResult> HorseRaceResults { get; }
    }
}
