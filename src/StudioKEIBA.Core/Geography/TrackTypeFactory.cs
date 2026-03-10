namespace StudioKEIBA.Geography
{
    static public class TrackTypeFactory
    {
        static public TrackType CreateFromString(string trackType)
        {
            if (trackType == "芝") return TrackType.芝;
            if (trackType == "ダ") return TrackType.ダ;

            return TrackType.Unknown;
        }
    }
}
