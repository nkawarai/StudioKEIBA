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

        /// <summary>
        /// 周回方向
        /// </summary>
        TrackTurningDirection TurningDirection { get; }
    }

    /// <summary>
    /// コーナー
    /// </summary>
    public enum TrackTurningDirection
    {
        //左回り、右回りを画面表示する前提はないのでenumで定義する
        Left, Right, Unknown
    }

}
