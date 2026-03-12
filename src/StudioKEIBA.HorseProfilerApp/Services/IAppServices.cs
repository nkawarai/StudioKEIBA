namespace StudioKEIBA.HorseProfilerApp.Services
{
    /// <summary>
    /// このアプリケーションのサービス
    /// </summary>
    internal interface IAppServices
    {
        /// <summary>
        /// 競走馬プロファイリングサービス
        /// </summary>
        IHorseProfilingService HorseProfilingService { get; }
    }
}
