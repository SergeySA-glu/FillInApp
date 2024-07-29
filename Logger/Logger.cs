using FillInApp.Helpers;
using FillInApp.Interfaces;
using System;

namespace FillInApp.Logger
{
    public class Logger : ILogger
    {
        public void LogInfo(string message)
        {
            LogHelper.InsertLog(message, LogLevel.Info);
        }

        public void LogWarning(string message)
        {
            LogHelper.InsertLog(message, LogLevel.Warning);
        }

        public void LogError(string message)
        {
            LogHelper.InsertLog(message, LogLevel.Error);
        }

        public void LogError(Exception ex)
        {
            LogHelper.InsertLog(ex.Message + "\n\n" + ex.StackTrace, LogLevel.Error);
        }
    }

    /// <summary>
    /// Критичность лога
    /// </summary>
    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }
}
