using StudioKEIBA.Horse;
using StudioKEIBA.Netkeiba;

namespace StudioKEIBA.HorseProfilerApp.Services.Impl
{
    /// <summary>
    /// 競走馬プロファイリングサービス　実装クラス
    /// </summary>
    internal class HorseProfilingService : IHorseProfilingService
    {
        /// <summary>
        /// horseIDの妥当性検証する
        /// </summary>
        /// <param name="horseID">検証するID</param>
        /// <returns></returns>
        public bool Validate(string horseID)
        {
            try
            {
                var _ = ValueObjectFactory.CreateHorseID(horseID);
                return true;
            }
            catch (Exception)
            {
                //HorseIDオブジェクトが正しく生成できなかった場合
                //falseを返す
                return false;
            }
        }

        /// <summary>
        /// 競走馬プロファイリングサービス
        /// </summary>
        /// <param name="horseID"></param>
        async public Task<IHorseProfile> MakeProfile(string horseID, IProgressDialog progressDialog)
        {
            var netkeibaHorseID = ValueObjectFactory.CreateHorseID(horseID);
            var agent = AgentFactory.CreateHorseScraperAgent();

            progressDialog.UpdateMessage("基本情報を取得しています...");
            progressDialog.UpdateProgressPercent(25);
            var horseName = await agent.GetHorseName(netkeibaHorseID);
            Thread.Sleep(1000);

            progressDialog.UpdateMessage("血統情報を取得しています...");
            progressDialog.UpdateProgressPercent(50);
            var pedigree = await agent.GetPedigree(netkeibaHorseID);
            Thread.Sleep(1000);

            progressDialog.UpdateMessage("戦歴情報を取得しています...");
            progressDialog.UpdateProgressPercent(75);
            var raceResults = await agent.GetRaceResults(netkeibaHorseID);
            return HorseFactory.CreateHorseProfile(horseName, pedigree, raceResults);
        }
    }
}
