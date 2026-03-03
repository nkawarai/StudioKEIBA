namespace StudioKEIBA.Netkeiba
{
    using Impl;

    static public class ValueObjectFactory
    {
        /// <summary>
        /// net競馬競走馬IDを作成する
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public IHorseID CreateHorseID(string id)
            => new HorseID(id);

        /// <summary>
        /// netkeibaの競走馬ページURLを作成する
        /// </summary>
        /// <param name="horseID">netkeiba競走馬ID</param>
        /// <returns></returns>
        static public IHorseURL CreateHorseURL(IHorseID horseID)
            => new HorseURL(horseID);
    }
}
