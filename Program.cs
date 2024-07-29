using FillInApp.GUI;
using FillInApp.Helpers;
using System;
using System.Windows.Forms;

namespace FillInApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogHelper.CreateLogDb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
