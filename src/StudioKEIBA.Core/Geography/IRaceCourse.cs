namespace StudioKEIBA
{
    /// <summary>
    /// 競馬場
    /// </summary>
    public interface IRaceCourse
    {
        /// <summary>
        /// 競馬場名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 表示名
        /// </summary>
        string DisplayName { get; } 
    }
}
