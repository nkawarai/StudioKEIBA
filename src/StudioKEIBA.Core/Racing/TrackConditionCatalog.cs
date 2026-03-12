using StudioKEIBA.Racing.Impl;

namespace StudioKEIBA
{
    static public class TrackConditionCatalog
    {
        private static readonly ITrackCondition _ryou = new TrackCondition("良", "良");
        private static readonly ITrackCondition _yayaomo = new TrackCondition("稍重", "稍");
        private static readonly ITrackCondition _omo = new TrackCondition("重", "重");
        private static readonly ITrackCondition _furyo = new TrackCondition("不良", "不");
        private static readonly IReadOnlyList<ITrackCondition> _all = [_ryou, _yayaomo, _omo, _furyo];

        static public ITrackCondition FindOrCreate(string displayName)
        {
            var candidate = _all.Where(x => x.DisplayName == displayName).FirstOrDefault();
            if (candidate != null)
            {
                return candidate;
            }
            return new TrackCondition("", "");
        }
    }
}
