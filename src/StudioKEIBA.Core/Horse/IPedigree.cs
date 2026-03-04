namespace StudioKEIBA
{
    /// <summary>
    ///  血統
    /// </summary>
    public interface IPedigree
    {
        /// <summary>
        /// 父
        /// </summary>
        IStallion Father { get; }

        /// <summary>
        /// 母父
        /// </summary>
        IStallion MotherFather { get; }
    }
}
