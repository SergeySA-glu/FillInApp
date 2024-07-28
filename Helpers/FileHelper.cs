using System.Windows.Forms;

namespace FillInApp.Helpers
{
    public static class FileHelper
    {
        public static string GetFilePath()
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Файлы шаблонов (*.doc)|*.doc| Файлы шаблонов (*.docx)|*.docx";
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return null;

                return fileDialog.FileName;
            }
        }
    }
}
