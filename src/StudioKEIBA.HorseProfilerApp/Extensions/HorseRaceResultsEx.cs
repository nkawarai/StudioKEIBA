namespace StudioKEIBA.HorseProfilerApp.Extensions
{
    using StudioKEIBA.Geography;
    using StudioKEIBA.Horse;
    using StudioKEIBA.Racing;
    using Views.ViewModels;

    static public class HorseRaceResultsEx
    {
        /// <summary>
        /// 競走馬レース結果をアプリ用のViewModelに変換する
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>

        static internal IEnumerable<HorseRaceResultViewModel> ConvertToHorseRaceResultViewModels(this IEnumerable<IHorseRaceResult> self)
        {
            var viewModels = new List<HorseRaceResultViewModel>();
            for (var i = 0; i < self.Count(); i++)
            {
                var result = self.ElementAt(i);
                var prev = i + 1 >= self.Count() ? null : self.ElementAt(i + 1); 
                var viewModel = HorseRaceResultViewModel.FromHorseRaceResult(result, prev);
                viewModels.Add(viewModel);
            }
            return viewModels;
        }

        /// <summary>
        /// 総合成績ViewModelを返す
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static internal IEnumerable<IRaceStasViewModel> ConvertToSummaryStatsVM(this IEnumerable<IHorseRaceResult> self)
        {
            var all = RaceStatsViewModel.Create("全成績", self.ResolveStats());
            var turf  = RaceStatsViewModel.Create(
                "芝",
                self.Where(x => x.Race.RaceTrack.TrackType == TrackType.芝)
                .ResolveStats());
            var durt = RaceStatsViewModel.Create(
                "ダート",
                self.Where(x => x.Race.RaceTrack.TrackType == TrackType.ダ)
                .ResolveStats());

            return new[] {all, turf, durt};
        }

        /// <summary>
        /// 競馬場別成績ViewModelを返す
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static internal IEnumerable<IRaceStasViewModel> ConvertToRaceCourseStatsVM(this IEnumerable<IHorseRaceResult> self)
        {
            return RaceCourseCatalog.All
                .Select(course => RaceStatsViewModel.Create(course.DisplayName, self.Where(x => x.Race.RaceTrack.RaceCourse.Name == course.Name).ResolveStats()));
        }

        /// <summary>
        /// コース形態での成績ViewModelを返す
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static internal IEnumerable<IRaceStasViewModel> ConvertToCourseShapeStatsVM(this IEnumerable<IHorseRaceResult> self)
        {
            var leftTurn = RaceStatsViewModel.Create(
                "左回り",
                self.Where(x => x.Race.RaceTrack.RaceCourse.TurningDirection == TrackTurningDirection.Left)
                .ResolveStats());

            var rightTurn = RaceStatsViewModel.Create(
                "右回り",
                self.Where(x => x.Race.RaceTrack.RaceCourse.TurningDirection == TrackTurningDirection.Right)
                .ResolveStats());

            var slopeStats = RaceStatsViewModel.Create(
                "急坂",
                self.Where(x => x.Race.RaceTrack.HasSlopeInStraight == true)
                .ResolveStats());

            var titeCournerStats = RaceStatsViewModel.Create(
                "小回り",
                self.Where(x => x.Race.RaceTrack.HasTightCorner == true)
                .ResolveStats());

            var shortStraightStats = RaceStatsViewModel.Create(
                "短直線",
                self.Where(x => x.Race.RaceTrack.StraightLength?.Meter < 400)
                .ResolveStats());

            return new[] {leftTurn, rightTurn, slopeStats, titeCournerStats, shortStraightStats};
        }

        /// <summary>
        /// ローテごとの成績ViewModelを返す
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static internal IEnumerable<IRaceStasViewModel> ConvertToDistanceRotationStatsVM(this IEnumerable<IHorseRaceResult> self)
        {
            var same = new List<IHorseRaceResult>();
            var extended = new List<IHorseRaceResult>();
            var shortened = new List<IHorseRaceResult>();
            var trackChanged = new List<IHorseRaceResult>();
            for (var i = 0; i < self.Count() - 1; i++) //前走比較なのでループ回数はレコード数より1減らす
            {
                var prevTrack = self.ElementAt(i + 1).Race.RaceTrack;
                var rotationName = self.ElementAt(i).Race.RaceTrack.ResolveDistanceRotation(prevTrack);
                if (rotationName == TrackEx.SAME)
                {
                    same.Add(self.ElementAt(i));
                }
                else if (rotationName == TrackEx.EXTENDED)
                {
                    extended.Add(self.ElementAt(i));
                }
                else if (rotationName == TrackEx.SHORTENED)
                {
                    shortened.Add(self.ElementAt(i));
                }
                else if (rotationName == TrackEx.CHANGE_TRACK)
                {
                    trackChanged.Add(self.ElementAt(i));
                }
            }

            var sameStatsVM = RaceStatsViewModel.Create("同距離", same.ResolveStats());
            var shortenedStatsVM = RaceStatsViewModel.Create("短縮", shortened.ResolveStats());
            var extendedStatsVM = RaceStatsViewModel.Create("延長", extended.ResolveStats());
            var trackChangedVM = RaceStatsViewModel.Create("馬場替わり", trackChanged.ResolveStats());

            return new[] {sameStatsVM, shortenedStatsVM, extendedStatsVM, trackChangedVM };
        }

        /// <summary>
        /// 季節ごとの成績ViewModelを返す
        /// </summary>
        static internal IEnumerable<IRaceStasViewModel> ConvertToSeasonStatsVM(this IEnumerable<IHorseRaceResult> self)
        {
            var winter = RaceStatsViewModel.Create(
                "12月～2月",
                self.Where(x => x.Race.RaceDate.Month == 12 || x.Race.RaceDate.Month == 1 || x.Race.RaceDate.Month == 2)
                .ResolveStats());

            var spring = RaceStatsViewModel.Create(
                "3月～5月",
                self.Where(x => x.Race.RaceDate.Month == 3 || x.Race.RaceDate.Month == 4 || x.Race.RaceDate.Month == 5)
                .ResolveStats());

            var summer = RaceStatsViewModel.Create(
                "6月～8月",
                self.Where(x => x.Race.RaceDate.Month == 6 || x.Race.RaceDate.Month == 7 || x.Race.RaceDate.Month == 8)
                .ResolveStats());


            var autumn = RaceStatsViewModel.Create(
                "9月～11月",
                self.Where(x => x.Race.RaceDate.Month == 9 || x.Race.RaceDate.Month == 10 || x.Race.RaceDate.Month == 11)
                .ResolveStats());

            return new[] {winter, spring, summer, autumn };
        }

        /// <summary>
        /// 着順を集計する
        /// </summary>
        static internal IRaceStats ResolveStats(this IEnumerable<IHorseRaceResult> results)
        {
            var first = results.Count(r => r.Rank.ToInt() == 1);
            var second = results.Count(r => r.Rank.ToInt() == 2);
            var third = results.Count(r => r.Rank.ToInt() == 3);
            var other = results.Count(r => r.Rank.ToInt() >= 4);
            return RaceFactory.CreateRaceStats(first, second, third, other);
        }
    }
}
