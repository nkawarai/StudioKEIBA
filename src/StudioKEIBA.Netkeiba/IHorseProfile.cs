namespace StudioKEIBA.Netkeiba
{
    /// <summary>
    /// 競走馬情報インターフェース
    /// </summary>
    public interface IHorseProfile
    {
        /// <summary>
        /// 馬名
        /// </summary>
        string HorseName { get; }

        /// <summary>
        /// netkeibaの競馬ID
        /// </summary>
        int NetKeibaHorseID { get; }
    }
}
