using FillInApp.Logger;
using System;
using System.Data.SQLite;
using System.IO;

namespace FillInApp.Helpers
{
    public static class LogHelper
    {
        private static string DbPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logBase.db");
        private static string ConnectionString => $"Data Source={DbPath};Version=3;";

        public static void CreateLogDb()
        {
            if (!File.Exists(DbPath))
            {
                SQLiteConnection.CreateFile(DbPath);
            }

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createTableCommand = @"CREATE TABLE IF NOT EXISTS Logs (
                                        ID INTEGER PRIMARY KEY,
                                        Date TEXT, 
                                        Message Text,
                                        LogLevel Text
                                    )";

                using (var command = new SQLiteCommand(createTableCommand, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static void InsertLog(string message, LogLevel logLevel)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string insertTableCommand = "INSERT INTO Logs (Date, Message, LogLevel) VALUES (:Date, :Message, :LogLevel)";

                using (var command = new SQLiteCommand(conn))
                {
                    command.CommandText = insertTableCommand;
                    command.Parameters.AddWithValue("Date", DateTime.Now.ToString("G"));
                    command.Parameters.AddWithValue("Message", message);
                    command.Parameters.AddWithValue("LogLevel", logLevel.ToString());
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
