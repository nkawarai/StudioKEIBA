using StudioKEIBA.Horse;
using StudioKEIBA.HorseProfilerApp.Views.Extensions;

namespace StudioKEIBA.HorseProfilerApp.Views.ViewModels
{
    /// <summary>
    /// 競走馬戦歴ViewModel
    /// </summary>
    internal class HorseRaceResultViewModel
    {
        /// <summary>
        /// 日付
        /// </summary>
        public string? Date { get; private set; }

        /// <summary>
        /// レース名
        /// </summary>
        public string? RaceName { get; private set; }

        /// <summary>
        /// レーストラック名
        /// </summary>
        public string? RaceTrackName { get; private set; }

        /// <summary>
        /// 急坂の有無
        /// </summary>
        public string? HasSlope { get; private set; }

        /// <summary>
        /// 小回りコースか
        /// </summary>
        public string? HasTightCorner { get; private set; }

        /// <summary>
        /// 短直線か
        /// </summary>
        public string? HomeStratchIsShort { get; private set; }

        /// <summary>
        /// 馬場状態
        /// </summary>
        public string? TrackCondition { get; private set; }

        /// <summary>
        /// 枠番
        /// </summary>
        public string? Wakuban { get; private set; }

        /// <summary>
        /// 馬番
        /// </summary>
        public string? Umaban { get; private set; }

        /// <summary>
        /// 内枠・外枠
        /// </summary>
        public string? UchiSoto { get; private set; }

        /// <summary>
        /// 着順
        /// </summary>
        public string? Rank { get; private set; }

        /// <summary>
        /// 騎手名(斤量)
        /// </summary>
        public string? JockeyAndWeight { get; private set; }

        /// <summary>
        /// 走破タイム
        /// </summary>
        public string? Time { get; private set; }

        /// <summary>
        /// あがりタイム
        /// </summary>
        public string? Agari { get; private set; }

        /// <summary>
        /// 距離ローテ
        /// </summary>
        public string? DistanceRotation { get; private set; }

        /// <summary>
        /// レース間隔
        /// </summary>
        public string? RaceInterval { get; private set; }

        /// <summary>
        /// factoryメソッド
        /// </summary>
        static public HorseRaceResultViewModel FromHorseRaceResult(IHorseRaceResult result, IHorseRaceResult? prev)
        {
            var viewModel = new HorseRaceResultViewModel();
            viewModel.Date = result.Race.RaceDate.ToShortDateString();
            viewModel.RaceName = result.Race.RaceName;
            viewModel.RaceTrackName = result.Race.RaceTrack.ToString();
            viewModel.TrackCondition = result.Race.TrackCondition.DisplayName;
            viewModel.Umaban = result.Umaban.ToString();
            viewModel.Wakuban = result.Wakuban.ToString();
            viewModel.Rank = result.Rank.ToString();
            viewModel.JockeyAndWeight = $"{result.JockeyName}({result.CarriedWeight.ToString("F1")}kg)";
            viewModel.Agari = result.AgariTime?.ToString("F1");
            if (result.AgariLank.HasValue)
            {
                viewModel.Agari += $"({result.AgariLank}位)";
            }

            if (result.Wakuban <= 2)
            {
                viewModel.UchiSoto = "内枠";
            }
            else if (result.Wakuban >= 7)
            {
                viewModel.UchiSoto = "外枠";
            }

            if (result.Race.RaceTrack.HasSlopeInStraight.HasValue && result.Race.RaceTrack.HasSlopeInStraight == true)
            {
                viewModel.HasSlope = "〇";
            }
            if (result.Race.RaceTrack.HasTightCorner.HasValue && result.Race.RaceTrack.HasTightCorner == true)
            {
                viewModel.HasTightCorner = "〇";
            }
            if (result.Race.RaceTrack.StraightLength != null && result.Race.RaceTrack.StraightLength.Meter < 400.0)
            {
                viewModel.HomeStratchIsShort = "〇";
            }
            if (prev == null) return viewModel;
            viewModel.DistanceRotation = result.Race.RaceTrack.ResolveDistanceRotation(prev.Race.RaceTrack);
            viewModel.RaceInterval = result.Race.RaceDate.ResolveRaceInterval(prev.Race.RaceDate);
            return viewModel;
        }
    }
}
