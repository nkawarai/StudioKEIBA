using StudioKEIBA.Geography.Impl;

namespace StudioKEIBA.Geography
{
    /// <summary>
    /// トラックカタログ
    /// </summary>
    public class TrackCatalog
    {
        public static ITrack? Find(string raceCourseName, TrackType trackType, int distanceM)
            => _all.FirstOrDefault(t =>
                t.RaceCourse.DisplayName == raceCourseName &&
                t.TrackType == trackType &&
                t.Distance.Meter == distanceM);

        public static IReadOnlyList<ITrack> GetAll() => _all;

        #region ====東京競馬場====

        // 東京芝1400m
        private static readonly ITrack TokyoT1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京芝1600m
        private static readonly ITrack TokyoT1600
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京芝1800m
        private static readonly ITrack TokyoT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京芝2000m
        private static readonly ITrack TokyoT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京芝2300m
        private static readonly ITrack TokyoT2300
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2300),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京芝2400m
        private static readonly ITrack TokyoT2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京芝2500m
        private static readonly ITrack TokyoT2500
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2500),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京芝3400m
        private static readonly ITrack TokyoT3400
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(3400),
                straightDistance: Distance.CreateFromMeter(526),
                hasSlope: false,
                hasTightCorner: false);

        // 東京ダ1300m
        private static readonly ITrack TokyoD1300
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1300),
                straightDistance: Distance.CreateFromMeter(502),
                hasSlope: false,
                hasTightCorner: false);

        // 東京ダ1400m
        private static readonly ITrack TokyoD1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(502),
                hasSlope: false,
                hasTightCorner: false);

        // 東京ダ1600m
        private static readonly ITrack TokyoD1600
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(502),
                hasSlope: false,
                hasTightCorner: false);

        // 東京ダ2100m
        private static readonly ITrack TokyoD2100
            = Track.Create(
                raceCourse: RaceCourseCatalog.TOKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2100),
                straightDistance: Distance.CreateFromMeter(502),
                hasSlope: false,
                hasTightCorner: false);

        #endregion

        #region ====中山競馬場====

        // 中山芝1200m
        private static readonly ITrack NakayamaT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(310),
                hasSlope: true,
                hasTightCorner: true);

        // 中山芝1600m
        private static readonly ITrack NakayamaT1600
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(310),
                hasSlope: true,
                hasTightCorner: true);

        // 中山芝1800m
        private static readonly ITrack NakayamaT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(310),
                hasSlope: true,
                hasTightCorner: true);

        // 中山芝2000m
        private static readonly ITrack NakayamaT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(310),
                hasSlope: true,
                hasTightCorner: true);

        // 中山芝2200m
        private static readonly ITrack NakayamaT2200
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2200),
                straightDistance: Distance.CreateFromMeter(310),
                hasSlope: true,
                hasTightCorner: true);

        // 中山芝2500m
        private static readonly ITrack NakayamaT2500
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2500),
                straightDistance: Distance.CreateFromMeter(310),
                hasSlope: true,
                hasTightCorner: true);

        // 中山芝3600m
        private static readonly ITrack NakayamaT3600
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(3600),
                straightDistance: Distance.CreateFromMeter(310),
                hasSlope: true,
                hasTightCorner: true);

        // 中山ダ1200m
        private static readonly ITrack NakayamaD1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(308),
                hasSlope: true,
                hasTightCorner: true);

        // 中山ダ1800m
        private static readonly ITrack NakayamaD1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(308),
                hasSlope: true,
                hasTightCorner: true);

        // 中山ダ2400m
        private static readonly ITrack NakayamaD2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(308),
                hasSlope: true,
                hasTightCorner: true);

        // 中山ダ2500m
        private static readonly ITrack NakayamaD2500
            = Track.Create(
                raceCourse: RaceCourseCatalog.NAKAYAMA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2500),
                straightDistance: Distance.CreateFromMeter(308),
                hasSlope: true,
                hasTightCorner: true);

        #endregion

        #region ====京都競馬場====

        // 京都芝1200m
        private static readonly ITrack KyotoT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(328),
                hasSlope: false,
                hasTightCorner: true);

        // 京都芝1400m（内）
        private static readonly ITrack KyotoT1400In
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(328),
                hasSlope: false,
                hasTightCorner: true);

        // 京都芝1400m（外）
        private static readonly ITrack KyotoT1400Out
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(404),
                hasSlope: false,
                hasTightCorner: false);

        // 京都芝1600m（内）
        private static readonly ITrack KyotoT1600In
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(328),
                hasSlope: false,
                hasTightCorner: true);

        // 京都芝1600m（外）
        private static readonly ITrack KyotoT1600Out
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(404),
                hasSlope: false,
                hasTightCorner: false);

        // 京都芝1800m
        private static readonly ITrack KyotoT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(404),
                hasSlope: false,
                hasTightCorner: false);

        // 京都芝2000m
        private static readonly ITrack KyotoT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(328),
                hasSlope: false,
                hasTightCorner: true);

        // 京都芝2200m
        private static readonly ITrack KyotoT2200
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2200),
                straightDistance: Distance.CreateFromMeter(404),
                hasSlope: false,
                hasTightCorner: false);

        // 京都芝2400m
        private static readonly ITrack KyotoT2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(404),
                hasSlope: false,
                hasTightCorner: false);

        // 京都芝3000m
        private static readonly ITrack KyotoT3000
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(3000),
                straightDistance: Distance.CreateFromMeter(404),
                hasSlope: false,
                hasTightCorner: false);

        // 京都芝3200m
        private static readonly ITrack KyotoT3200
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(3200),
                straightDistance: Distance.CreateFromMeter(404),
                hasSlope: false,
                hasTightCorner: false);

        // 京都ダ1200m
        private static readonly ITrack KyotoD1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(329),
                hasSlope: false,
                hasTightCorner: true);

        // 京都ダ1400m
        private static readonly ITrack KyotoD1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(329),
                hasSlope: false,
                hasTightCorner: true);

        // 京都ダ1800m
        private static readonly ITrack KyotoD1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(329),
                hasSlope: false,
                hasTightCorner: true);

        // 京都ダ1900m
        private static readonly ITrack KyotoD1900
            = Track.Create(
                raceCourse: RaceCourseCatalog.KYOTO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1900),
                straightDistance: Distance.CreateFromMeter(329),
                hasSlope: false,
                hasTightCorner: true);

        #endregion

        #region ====阪神競馬場====

        // 阪神芝1200m
        private static readonly ITrack HanshinT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(357),
                hasSlope: true,
                hasTightCorner: true);

        // 阪神芝1400m
        private static readonly ITrack HanshinT1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(357),
                hasSlope: true,
                hasTightCorner: true);

        // 阪神芝1600m（外）
        private static readonly ITrack HanshinT1600
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(474),
                hasSlope: true,
                hasTightCorner: false);

        // 阪神芝1800m（外）
        private static readonly ITrack HanshinT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(474),
                hasSlope: true,
                hasTightCorner: false);

        // 阪神芝2000m（内）
        private static readonly ITrack HanshinT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(357),
                hasSlope: true,
                hasTightCorner: true);

        // 阪神芝2200m（外）
        private static readonly ITrack HanshinT2200
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2200),
                straightDistance: Distance.CreateFromMeter(474),
                hasSlope: true,
                hasTightCorner: false);

        // 阪神芝2400m（外）
        private static readonly ITrack HanshinT2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(474),
                hasSlope: true,
                hasTightCorner: false);

        // 阪神芝3000m（外）
        private static readonly ITrack HanshinT3000
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(3000),
                straightDistance: Distance.CreateFromMeter(474),
                hasSlope: true,
                hasTightCorner: false);

        // 阪神芝3200m（外）
        private static readonly ITrack HanshinT3200
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(3200),
                straightDistance: Distance.CreateFromMeter(474),
                hasSlope: true,
                hasTightCorner: false);

        // 阪神ダ1200m
        private static readonly ITrack HanshinD1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(353),
                hasSlope: true,
                hasTightCorner: true);

        // 阪神ダ1400m
        private static readonly ITrack HanshinD1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(353),
                hasSlope: true,
                hasTightCorner: true);

        // 阪神ダ1800m
        private static readonly ITrack HanshinD1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(353),
                hasSlope: true,
                hasTightCorner: true);

        // 阪神ダ2000m
        private static readonly ITrack HanshinD2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.HANSHIN,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(353),
                hasSlope: true,
                hasTightCorner: true);

        #endregion

        #region ====中京競馬場====

        // 中京芝1200m
        private static readonly ITrack ChukyoT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(413),
                hasSlope: true,
                hasTightCorner: false);

        // 中京芝1400m
        private static readonly ITrack ChukyoT1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(413),
                hasSlope: true,
                hasTightCorner: false);

        // 中京芝1600m
        private static readonly ITrack ChukyoT1600
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(413),
                hasSlope: true,
                hasTightCorner: false);

        // 中京芝2000m
        private static readonly ITrack ChukyoT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(413),
                hasSlope: true,
                hasTightCorner: false);

        // 中京芝2200m
        private static readonly ITrack ChukyoT2200
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2200),
                straightDistance: Distance.CreateFromMeter(413),
                hasSlope: true,
                hasTightCorner: false);

        // 中京ダ1200m
        private static readonly ITrack ChukyoD1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(411),
                hasSlope: true,
                hasTightCorner: false);

        // 中京ダ1400m
        private static readonly ITrack ChukyoD1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(411),
                hasSlope: true,
                hasTightCorner: false);

        // 中京ダ1800m
        private static readonly ITrack ChukyoD1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(411),
                hasSlope: true,
                hasTightCorner: false);

        // 中京ダ1900m
        private static readonly ITrack ChukyoD1900
            = Track.Create(
                raceCourse: RaceCourseCatalog.CHUKYO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1900),
                straightDistance: Distance.CreateFromMeter(411),
                hasSlope: true,
                hasTightCorner: false);

        #endregion

        #region ====札幌競馬場====

        // 札幌芝1200m
        private static readonly ITrack SapporoT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(266),
                hasSlope: false,
                hasTightCorner: false);

        // 札幌芝1500m
        private static readonly ITrack SapporoT1500
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1500),
                straightDistance: Distance.CreateFromMeter(266),
                hasSlope: false,
                hasTightCorner: false);

        // 札幌芝1800m
        private static readonly ITrack SapporoT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(266),
                hasSlope: false,
                hasTightCorner: false);

        // 札幌芝2000m
        private static readonly ITrack SapporoT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(266),
                hasSlope: false,
                hasTightCorner: false);

        // 札幌芝2600m
        private static readonly ITrack SapporoT2600
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2600),
                straightDistance: Distance.CreateFromMeter(266),
                hasSlope: false,
                hasTightCorner: false);

        // 札幌ダ1000m
        private static readonly ITrack SapporoD1000
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1000),
                straightDistance: Distance.CreateFromMeter(264),
                hasSlope: false,
                hasTightCorner: false);

        // 札幌ダ1700m
        private static readonly ITrack SapporoD1700
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1700),
                straightDistance: Distance.CreateFromMeter(264),
                hasSlope: false,
                hasTightCorner: false);

        // 札幌ダ2400m
        private static readonly ITrack SapporoD2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.SAPPORO,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(264),
                hasSlope: false,
                hasTightCorner: false);

        #endregion

        #region ====函館競馬場====

        // 函館芝1200m
        private static readonly ITrack HakodateT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.HAKODATE,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(262),
                hasSlope: false,
                hasTightCorner: true);

        // 函館芝1800m
        private static readonly ITrack HakodateT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.HAKODATE,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(262),
                hasSlope: false,
                hasTightCorner: true);

        // 函館芝2000m
        private static readonly ITrack HakodateT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.HAKODATE,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(262),
                hasSlope: false,
                hasTightCorner: true);

        // 函館芝2600m
        private static readonly ITrack HakodateT2600
            = Track.Create(
                raceCourse: RaceCourseCatalog.HAKODATE,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2600),
                straightDistance: Distance.CreateFromMeter(262),
                hasSlope: false,
                hasTightCorner: true);

        // 函館ダ1000m
        private static readonly ITrack HakodateD1000
            = Track.Create(
                raceCourse: RaceCourseCatalog.HAKODATE,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1000),
                straightDistance: Distance.CreateFromMeter(260),
                hasSlope: false,
                hasTightCorner: true);

        // 函館ダ1700m
        private static readonly ITrack HakodateD1700
            = Track.Create(
                raceCourse: RaceCourseCatalog.HAKODATE,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1700),
                straightDistance: Distance.CreateFromMeter(260),
                hasSlope: false,
                hasTightCorner: true);

        // 函館ダ2400m
        private static readonly ITrack HakodateD2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.HAKODATE,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(260),
                hasSlope: false,
                hasTightCorner: true);

        #endregion

        #region ====福島競馬場====

        // 福島芝1200m
        private static readonly ITrack FukushimaT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.FUKUSHIMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(292),
                hasSlope: false,
                hasTightCorner: true);

        // 福島芝1800m
        private static readonly ITrack FukushimaT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.FUKUSHIMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(292),
                hasSlope: false,
                hasTightCorner: true);

        // 福島芝2000m
        private static readonly ITrack FukushimaT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.FUKUSHIMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(292),
                hasSlope: false,
                hasTightCorner: true);

        // 福島芝2600m
        private static readonly ITrack FukushimaT2600
            = Track.Create(
                raceCourse: RaceCourseCatalog.FUKUSHIMA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2600),
                straightDistance: Distance.CreateFromMeter(292),
                hasSlope: false,
                hasTightCorner: true);

        // 福島ダ1150m
        private static readonly ITrack FukushimaD1150
            = Track.Create(
                raceCourse: RaceCourseCatalog.FUKUSHIMA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1150),
                straightDistance: Distance.CreateFromMeter(296),
                hasSlope: false,
                hasTightCorner: true);

        // 福島ダ1700m
        private static readonly ITrack FukushimaD1700
            = Track.Create(
                raceCourse: RaceCourseCatalog.FUKUSHIMA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1700),
                straightDistance: Distance.CreateFromMeter(296),
                hasSlope: false,
                hasTightCorner: true);

        // 福島ダ2400m
        private static readonly ITrack FukushimaD2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.FUKUSHIMA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(296),
                hasSlope: false,
                hasTightCorner: true);

        #endregion

        #region ====新潟競馬場====

        // 新潟芝1000m（直線）
        private static readonly ITrack NiigataT1000
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1000),
                straightDistance: Distance.CreateFromMeter(1000),
                hasSlope: false,
                hasTightCorner: false);

        // 新潟芝1200m
        private static readonly ITrack NiigataT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(359),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟芝1400m
        private static readonly ITrack NiigataT1400
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1400),
                straightDistance: Distance.CreateFromMeter(359),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟芝1600m
        private static readonly ITrack NiigataT1600
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1600),
                straightDistance: Distance.CreateFromMeter(659),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟芝1800m
        private static readonly ITrack NiigataT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(659),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟芝2000m(内回り)
        private static readonly ITrack NiigataT2000In
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(359),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟芝2000m（外）
        private static readonly ITrack NiigataT2000Out
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(659),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟芝2200m（外）
        private static readonly ITrack NiigataT2200
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2200),
                straightDistance: Distance.CreateFromMeter(659),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟芝2400m（外）
        private static readonly ITrack NiigataT2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(659),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟ダ1200m
        private static readonly ITrack NiigataD1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(354),
                hasSlope: false,
                hasTightCorner: true);

        // 新潟ダ1800m
        private static readonly ITrack NiigataD1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.NIIGATA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(354),
                hasSlope: false,
                hasTightCorner: true);

        #endregion

        #region ====小倉競馬場====

        // 小倉芝1200m
        private static readonly ITrack KokuraT1200
            = Track.Create(
                raceCourse: RaceCourseCatalog.KOKURA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1200),
                straightDistance: Distance.CreateFromMeter(293),
                hasSlope: false,
                hasTightCorner: true);

        // 小倉芝1800m
        private static readonly ITrack KokuraT1800
            = Track.Create(
                raceCourse: RaceCourseCatalog.KOKURA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(1800),
                straightDistance: Distance.CreateFromMeter(293),
                hasSlope: false,
                hasTightCorner: true);

        // 小倉芝2000m
        private static readonly ITrack KokuraT2000
            = Track.Create(
                raceCourse: RaceCourseCatalog.KOKURA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2000),
                straightDistance: Distance.CreateFromMeter(293),
                hasSlope: false,
                hasTightCorner: true);

        // 小倉芝2600m
        private static readonly ITrack KokuraT2600
            = Track.Create(
                raceCourse: RaceCourseCatalog.KOKURA,
                trackType: TrackType.芝,
                distance: Distance.CreateFromMeter(2600),
                straightDistance: Distance.CreateFromMeter(293),
                hasSlope: false,
                hasTightCorner: true);

        // 小倉ダ1000m
        private static readonly ITrack KokuraD1000
            = Track.Create(
                raceCourse: RaceCourseCatalog.KOKURA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1000),
                straightDistance: Distance.CreateFromMeter(291),
                hasSlope: false,
                hasTightCorner: true);

        // 小倉ダ1700m
        private static readonly ITrack KokuraD1700
            = Track.Create(
                raceCourse: RaceCourseCatalog.KOKURA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(1700),
                straightDistance: Distance.CreateFromMeter(291),
                hasSlope: false,
                hasTightCorner: true);

        // 小倉ダ2400m
        private static readonly ITrack KokuraD2400
            = Track.Create(
                raceCourse: RaceCourseCatalog.KOKURA,
                trackType: TrackType.ダ,
                distance: Distance.CreateFromMeter(2400),
                straightDistance: Distance.CreateFromMeter(291),
                hasSlope: false,
                hasTightCorner: true);

        #endregion

        private static readonly IReadOnlyList<ITrack> _all =
        [
            // 東京
            TokyoT1400,
            TokyoT1600,
            TokyoT1800,
            TokyoT2000,
            TokyoT2300,
            TokyoT2400,
            TokyoT2500,
            TokyoT3400,
            TokyoD1300,
            TokyoD1400,
            TokyoD1600,
            TokyoD2100,

            // 中山
            NakayamaT1200, 
            NakayamaT1600,
            NakayamaT1800,
            NakayamaT2000,
            NakayamaT2200,
            NakayamaT2500,
            NakayamaT3600,
            NakayamaD1200,
            NakayamaD1800,
            NakayamaD2400,
            NakayamaD2500,

            // 京都
            KyotoT1200,
            //KyotoT1400In,
            KyotoT1400Out,
            //KyotoT1600In,
            KyotoT1600Out,
            KyotoT1800,
            KyotoT2000,
            KyotoT2200,
            KyotoT2400,
            KyotoT3000,
            KyotoT3200,
            KyotoD1200,
            KyotoD1400,
            KyotoD1800,
            KyotoD1900,

            // 阪神
            HanshinT1200,
            HanshinT1400,
            HanshinT1600,
            HanshinT1800,
            HanshinT2000,
            HanshinT2200,
            HanshinT2400,
            HanshinT3000,
            HanshinT3200,
            HanshinD1200,
            HanshinD1400,
            HanshinD1800,
            HanshinD2000,

            // 中京
            ChukyoT1200,
            ChukyoT1400,
            ChukyoT1600,
            ChukyoT2000,
            ChukyoT2200,
            ChukyoD1200,
            ChukyoD1400,
            ChukyoD1800,
            ChukyoD1900,

            // 札幌
            SapporoT1200,
            SapporoT1500,
            SapporoT1800,
            SapporoT2000,
            SapporoT2600,
            SapporoD1000,
            SapporoD1700,
            SapporoD2400,

            // 函館
            HakodateT1200,
            HakodateT1800,
            HakodateT2000,
            HakodateT2600,
            HakodateD1000,
            HakodateD1700,
            HakodateD2400,

            // 福島
            FukushimaT1200,
            FukushimaT1800,
            FukushimaT2000,
            FukushimaT2600,
            FukushimaD1150,
            FukushimaD1700,
            FukushimaD2400,

            // 新潟
            NiigataT1000,
            NiigataT1200,
            NiigataT1400,
            NiigataT1600,
            NiigataT1800,
            //NiigataT2000In,
            NiigataT2000Out,
            NiigataT2200,
            NiigataT2400,
            NiigataD1200,
            NiigataD1800,

            // 小倉
            KokuraT1200,
            KokuraT1800,
            KokuraT2000,
            KokuraT2600,
            KokuraD1000,
            KokuraD1700,
            KokuraD2400,
        ];
    }
}
