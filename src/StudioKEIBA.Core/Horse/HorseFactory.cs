using StudioKEIBA.Horse;
using StudioKEIBA.Horse.Imple;
using System.Text.RegularExpressions;

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

        static public IHorseRaceResult CreateHorseRaceResult(IRace race, int? wakuban, int umaban, double? odds, int? populality,
            IRank rank, string jockeyName, double carriedWeight, string passingOrder,
            double? agariTime, int? agariLank, IHorseWeight horseWeight)
            => new HorseRaceResult(race, wakuban, umaban, odds, populality, rank, jockeyName, carriedWeight, passingOrder,
                agariTime, agariLank, horseWeight);

        static public IHorseWeight CreateHorseWeight(string netkeibaWeightExpression)
        {
            var match = Regex.Match(netkeibaWeightExpression, @"(\d+)\(([+-]?\d+)\)");
            if (!match.Success)
            {
                return new HorseWeight(null);              
            }

            var weight = int.Parse(match.Groups[1].Value);
            var diff = int.Parse(match.Groups[2].Value);
            return new HorseWeight(weight, diff);
        }

        static public IHorseProfile CreateHorseProfile(string name, IPedigree pedigree, IEnumerable<IHorseRaceResult> horseRaceResults)
            => new HorseProfile(name, pedigree, horseRaceResults);

        static public IRank CreateRank(string rankStr)
            => new Rank(rankStr);
    }
}
