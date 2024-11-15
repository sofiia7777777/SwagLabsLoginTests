using Serilog;
using Serilog.Events;

namespace SwagLabsLoginTests.Utils
{
    public static class TestLogger
    {
        static TestLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File("C:\\Automation_Testing_C#\\SwagLabsLoginTests\\Utils\\log.txt", rollingInterval: RollingInterval.Infinite)
                .CreateLogger();
        }

        public static void Initialize()
        {
            Log.Information("Initializing the logger.");
        }
    }
}
