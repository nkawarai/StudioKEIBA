namespace StudioKEIBA.Geography.Impl
{
    /// <summary>
    /// 競馬場 実装クラス
    /// </summary>
    internal class RaceCourse : IRaceCourse
    {
        /// <summary>
        /// 競馬場名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 表示名
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// ファクトリメソッド
        /// </summary>
        /// <param name="name">競馬場名</param>
        /// <param name="displayName">競馬場表示名</param>
        /// <returns></returns>
        static public IRaceCourse Create(string name, string displayName)
            => new RaceCourse(name, displayName);

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        private RaceCourse(string name, string displayName)
        {
            Name = name;
            DisplayName = displayName;
        }
    }
}
