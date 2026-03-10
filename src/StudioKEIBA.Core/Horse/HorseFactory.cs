using StudioKEIBA.Horse;
using StudioKEIBA.Horse.Imple;

namespace StudioKEIBA
{
    /// <summary>
    /// ファクトリークラス
    /// </summary>
    static public class HorseFactory
    {
        static public IStallion CreateStallion(string horseName)
            => new Stallion(horseName);

        static public IPedigree CreatePedigree(IStallion father, IStallion motherFather)
            => new Pedigree(father, motherFather);

        static public IPedigree CreatePedigree(string fatherHorseName, string motherFatherHorseName)
            => new Pedigree(CreateStallion(fatherHorseName), CreateStallion(motherFatherHorseName));

        static public IHorseRaceResult CreateHorseRaceResult(IRace race, int wakuban, int umaban, double odds, int populality,
            int rank, string jockeyName, double carriedWeight, string passingOrder,
            double agariTime, int? agariLank, double horseWeight)
            => new HorseRaceResult(race, wakuban, umaban, odds, populality, rank, jockeyName, carriedWeight, passingOrder,
                agariTime, agariLank, horseWeight);
    }
}
