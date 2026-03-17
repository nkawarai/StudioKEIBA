using StudioKEIBA.Racing.Impl;

namespace StudioKEIBA.Racing
{
    static public class RaceFactory
    {
        static public IRace Create(DateOnly raceDate, ITrack raceTrack, int? raceNumber, string raceName, Uri raceUri, int horseNum,
            ITrackCondition condition, string weather, double? first3F, double? last3F)
            => new Race(raceDate, raceTrack, raceNumber, raceName, raceUri, horseNum, condition, weather, first3F, last3F);
    }
}
