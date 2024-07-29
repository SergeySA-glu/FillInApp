using FillInApp.Helpers;
using FillInApp.Interfaces;
using Microsoft.Office.Interop.Word;
using System;
using System.IO;

namespace FillInApp.Actions
{
    /// <summary>
    /// Сохранение заполненного документа на диск
    /// </summary>
    public class UploadAction : IUserAction
    {
        public void Execute(IOfficeWrapper wrapper)
        {
            if (wrapper == null)
                throw new ArgumentNullException(nameof(wrapper));

            var filePath = string.Empty;
            try
            {
                // создание документа
                filePath = FileHelper.GetDocumentFilePath(wrapper);
                if (filePath == null)
                    return;

                // открытие документа для изменения
                var doc = WordOfficeHelper.Application.Documents.Add(wrapper.PatternFilePath);

                foreach (Bookmark bookmark in doc.Bookmarks)
                {
                    if (wrapper.Changes.TryGetValue(bookmark.Name, out string newText))
                        bookmark.Range.Text = newText;
                }

                // сохранение и закрытие документа
                doc.SaveAs2(FileName: filePath);
                doc.Close();

                wrapper.DocumentFilePath = filePath;
            }
            catch
            {
                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    File.Delete(filePath);
                throw;
            }
        }
    }
}
