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
        /// その他さまざまな観点での成績ViewModelを返す
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        static internal IEnumerable<IRaceStasViewModel> ConverToVariousStatsVM(this IEnumerable<IHorseRaceResult> self)
        {
            var slopeStats = RaceStatsViewModel.Create("急坂", self.Where(x => x.Race.RaceTrack.HasSlopeInStraight == true).ResolveStats());
            var titeCournerStats = RaceStatsViewModel.Create("小回り", self.Where(x => x.Race.RaceTrack.HasTightCorner == true).ResolveStats());
            var shortStraightStats = RaceStatsViewModel.Create("短直線", self.Where(x => x.Race.RaceTrack.StraightLength?.Meter < 400).ResolveStats());

            return new[] {slopeStats, titeCournerStats, shortStraightStats};
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
