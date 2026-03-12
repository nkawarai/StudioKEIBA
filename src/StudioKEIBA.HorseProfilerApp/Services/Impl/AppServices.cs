namespace StudioKEIBA.HorseProfilerApp.Services.Impl
{
    /// <summary>
    /// アプリケーションのサービスクラス
    /// </summary>
    internal class AppServices : IAppServices
    {
        /// <summary>
        /// 競走馬プロファイリングサービス
        /// </summary>
        public IHorseProfilingService HorseProfilingService { get; }

        /// <summary>
        /// ファクトリメソッド
        /// </summary>
        /// <returns></returns>
        static public IAppServices Create(IHorseProfilingService horseProfilingService)
            => new AppServices(horseProfilingService);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private AppServices(IHorseProfilingService horseProfilingService)
        {
            HorseProfilingService = horseProfilingService;
        }
    }
}
