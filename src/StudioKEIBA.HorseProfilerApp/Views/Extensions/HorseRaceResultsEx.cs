namespace StudioKEIBA.HorseProfilerApp.Views.Extensions
{
    using StudioKEIBA.Horse;
    using ViewModels;

    static public class HorseRaceResultsEx
    {
        /// <summary>
        /// 競走馬レース結果をアプリ用のViewModelに変換する
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>

        static internal IEnumerable<HorseRaceResultViewModel> ConvertToViewModels(this IEnumerable<IHorseRaceResult> self)
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
    }
}
