namespace StudioKEIBA.Horse
{
    /// <summary>
    /// レース着順
    /// </summary>
    public interface IRank
    {
        /// <summary>
        /// int型に変換する
        /// </summary>
        /// <returns></returns>
        /// <remarks>競争中止や出走取消の場合はnullを返す</remarks>
        int? ToInt();
    }
}
