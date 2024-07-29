using FillInApp.Helpers;
using FillInApp.Interfaces;
using System;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;

namespace FillInApp.Actions
{
    /// <summary>
    /// Загрузка данных из шаблона для изменения
    /// </summary>
    public class DownloadAction : IUserAction
    {
        public void Execute(IOfficeWrapper wrapper)
        {
            if (wrapper == null)
                throw new ArgumentNullException(nameof(wrapper));

            // выбор файла
            var filePath = FileHelper.GetPatternFilePath();
            if (filePath == null)
                return;

            var doc = WordOfficeHelper.Application.Documents.Add(filePath);

            var bookMarkNames = new HashSet<string>();
            var defaultChanges = new Dictionary<string, string>();

            foreach (Word.Bookmark bookMark in doc.Bookmarks)
            {
                bookMarkNames.Add(bookMark.Name);
                defaultChanges[bookMark.Name] = string.Empty;
            }
            doc.Close();

            wrapper.BookmarksNames = bookMarkNames;
            wrapper.Changes = defaultChanges;
            wrapper.PatternFilePath = filePath;
        }
    }
}
