using StudioKEIBA.Horse;

namespace StudioKEIBA.HorseProfilerApp.Services
{
    /// <summary>
    /// 競走馬サービス
    /// </summary>
    internal interface IHorseProfilingService
    {
        /// <summary>
        /// horseIDの妥当性検証する
        /// </summary>
        /// <param name="horseID">検証するID</param>
        /// <returns></returns>
        bool Validate(string horseID);

        /// <summary>
        /// 競走馬プロファイリングサービス
        /// </summary>
        /// <param name="horseID"></param>
        Task<IHorseProfile> MakeProfile(string horseID);
    }
}
