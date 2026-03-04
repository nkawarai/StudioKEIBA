namespace StudioKEIBA
{
    /// <summary>
    /// ファクトリークラス
    /// </summary>
    static public class Factory
    {
        static public IStallion CreateStallion(string horseName)
            => new Stallion(horseName);

        static public IPedigree CreatePedigree(IStallion father, IStallion motherFather)
            => new Pedigree(father, motherFather);

        static public IPedigree CreatePedigree(string fatherHorseName, string motherFatherHorseName)
            => new Pedigree(CreateStallion(fatherHorseName), CreateStallion(motherFatherHorseName));
    }
}
