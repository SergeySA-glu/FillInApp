using FillInApp.Interfaces;
using System;
using System.IO;
using System.Windows.Forms;

namespace FillInApp.Helpers
{
    public static class FileHelper
    {
        /// <summary>
        /// Выбор шаблона документа с диска
        /// </summary>
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

        /// <summary>
        /// Создание файла документа для заполнения
        /// </summary>
        /// <param name="wrapper"></param>
        public static string GetDocumentFilePath(IOfficeWrapper wrapper)
        {
            if (wrapper == null)
                throw new ArgumentNullException(nameof(wrapper));

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
