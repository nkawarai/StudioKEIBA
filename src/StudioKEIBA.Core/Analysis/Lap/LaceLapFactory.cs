
namespace StudioKEIBA.Analysis
{
    using Lap.Impl;

    public class LaceLapFactory
    {
        static public IRaceLap CreateFromFurlongLap(IEnumerable<double> lap)
            => new RaceLap(lap);
    }
}
