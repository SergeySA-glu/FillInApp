using FillInApp.Interfaces;
using System.IO;
using System.Windows.Forms;

namespace FillInApp.Helpers
{
    public static class FileHelper
    {
        public static string GetPatternFilePath()
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

        public static string GetDocumentFilePath(IOfficeWrapper wrapper)
        {
            var filter = string.Empty;
            var exts = wrapper.Extensions;
            for (var i = 0; i < exts.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(exts[i]))
                    filter += $"Файлы документов (*.{exts[i]})|*.{exts[i]}";
                if (exts.Length > i + 1)
                    filter += "|";
            }

            using (var fileDialog = new SaveFileDialog())
            {
                fileDialog.InitialDirectory = Path.GetDirectoryName(wrapper.PatternFilePath);
                fileDialog.Filter = filter;
                fileDialog.AddExtension = true;
                fileDialog.FileName = "Заполненный документ";

                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return null;

                return fileDialog.FileName;
            }
        }
    }
}
