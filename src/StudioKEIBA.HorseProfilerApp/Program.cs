using Serilog;

namespace StudioKEIBA.HorseProfilerApp
{
    internal static class Program
    {
        static public string AppName = "HorseProfiler";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

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

            Application.Run(new FormMain());
        }
    }
}