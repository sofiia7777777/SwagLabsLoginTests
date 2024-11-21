using Serilog;

namespace Core
{
    public static class TestLogger
    {
        static TestLogger()
        {
                Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File("C:\\ClonedRepoCsharp\\SwagLabsLoginTests\\Core\\log.txt", rollingInterval: RollingInterval.Infinite)
                .CreateLogger();
        }

        public static void Initialize()
        {
            Log.Information("Initializing the logger.");
        }
    }
}
