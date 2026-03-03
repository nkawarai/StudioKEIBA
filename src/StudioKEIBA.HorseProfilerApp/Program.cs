using Serilog;

namespace StudioKEIBA.HorseProfilerApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/log-.txt",
                                rollingInterval: RollingInterval.Day, // 1日ごとに新ファイル作成
                                retainedFileCountLimit: 30,            // 直近30日分だけ保持（古いのは自動削除）
                                fileSizeLimitBytes: 10 * 1024 * 1024, // 1ファイル10MB制限
                                rollOnFileSizeLimit: true)            // サイズ上限に達したら新しいファイルを作る
                            .CreateLogger();

            Log.Information("アプリが起動しました。");

            Application.Run(new FormMain());
        }
    }
}