using Serilog;

namespace StudioKEIBA.HorseProfilerApp
{
    using StudioKEIBA.HorseProfilerApp.Services;
    using StudioKEIBA.HorseProfilerApp.Services.Impl;
    using Views;

    internal static class Program
    {
        static public string AppName = "HorseProfiler";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //二重起動の抑制
            const string mutexName = "Global\\StudioKEIBA.HorseProfileApp";
            using var mutex = new Mutex(initiallyOwned: true, mutexName, out bool createdNew);
            if (!createdNew)
            {
                Message.ShowWarningMessage(null, "アプリケーションは既に起動しています。");
                return;
            }

            var localAppDirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var logDirPath = Path.Combine(localAppDirPath, AppName, "logs");
            var logFilePath = Path.Combine(logDirPath, "log-.txt");
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(path: logFilePath,
                                rollingInterval: RollingInterval.Day,
                                retainedFileCountLimit: 30,
                                fileSizeLimitBytes: 10 * 1024 * 1024,
                                rollOnFileSizeLimit: true)
                            .CreateLogger();

            Log.Information("アプリが起動しました。");

            //サービス
            var horseProfilingService = ServiceFactory.CreateHorseProfilingService();
            var appServices = AppServices.Create(horseProfilingService);

            //メイン画面にサービス一覧を渡す
            Application.Run(new FormMain(appServices));
        }
    }
}