using System;

namespace FillInApp.Interfaces
{
    public interface ILogger
    {
        /// <summary>
        /// Запись в логи о текущем процессе
        /// </summary>
        void LogInfo(string message);
        /// <summary>
        /// Запись в логи о непредвиденном событии
        /// </summary>
        void LogWarning(string message);
        /// <summary>
        /// Запись в логи об ошибке
        /// </summary>
        void LogError(string message);
        /// <summary>
        /// Запись в логи об ошибке
        /// </summary>
        void LogError(Exception ex);
    }
}
