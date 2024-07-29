using FillInApp.Interfaces;

namespace FillInApp.Logger
{
    /// <summary>
    /// Вспомогательный класс для получения логгера
    /// </summary>
    public static class LogManager
    {
        private static ILogger _logger;
        public static ILogger GetLogger()
        {
            return _logger ?? new Logger();
        }
    }
}
