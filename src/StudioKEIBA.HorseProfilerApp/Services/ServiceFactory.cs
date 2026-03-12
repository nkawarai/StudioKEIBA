using StudioKEIBA.HorseProfilerApp.Services.Impl;

namespace StudioKEIBA.HorseProfilerApp.Services
{
    static internal class ServiceFactory
    {
        static public IHorseProfilingService CreateHorseProfilingService()
            => new HorseProfilingService();
    }
}
