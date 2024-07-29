using FillInApp.Interfaces;

namespace FillInApp.Logger
{
    public static class LogManager
    {
        private static ILogger _logger;
        public static ILogger GetLogger()
        {
            return _logger ?? new Logger();
        }
    }
}
