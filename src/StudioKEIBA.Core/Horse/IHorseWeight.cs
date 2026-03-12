namespace StudioKEIBA.Horse
{
    /// <summary>
    /// 場体重
    /// </summary>
    public interface IHorseWeight
    {
        /// <summary>
        /// 重さ[kg]
        /// </summary>
        int ValueKg { get; }

        /// <summary>
        /// 表示形式
        /// </summary>
        string DisplayWeight { get; }
    }
}
