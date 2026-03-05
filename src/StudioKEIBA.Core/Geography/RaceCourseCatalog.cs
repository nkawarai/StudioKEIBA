using StudioKEIBA.Geography.Impl;

namespace StudioKEIBA.Geography
{
    public class RaceCourseCatalog
    {
        public static readonly IRaceCourse TOKYO = RaceCourse.Create("東京競馬場", "東京");
        public static readonly IRaceCourse NAKAYAMA = RaceCourse.Create("中山競馬場", "中山");
        public static readonly IRaceCourse KYOTO = RaceCourse.Create("京都競馬場", "京都");
        public static readonly IRaceCourse HANSHIN = RaceCourse.Create("阪神競馬場", "阪神");
        public static readonly IRaceCourse SAPPORO = RaceCourse.Create("札幌競馬場", "札幌");
        public static readonly IRaceCourse HAKODATE = RaceCourse.Create("函館競馬場", "函館");
        public static readonly IRaceCourse FUKUSHIMA = RaceCourse.Create("福島競馬場", "福島");
        public static readonly IRaceCourse NIIGATA = RaceCourse.Create("新潟競馬場", "新潟");
        public static readonly IRaceCourse CHUKYO = RaceCourse.Create("中京競馬場", "中京");
        public static readonly IRaceCourse KOKURA = RaceCourse.Create("小倉競馬場", "小倉");
    }
}
