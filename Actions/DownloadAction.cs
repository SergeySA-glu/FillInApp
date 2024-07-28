using FillInApp.Helpers;
using FillInApp.Interfaces;
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
            // выбор файла
            var filePath = FileHelper.GetFilePath();

            var doc = WordOfficeHelper.Application.Documents.Add(filePath);

            var bookMarkNames = new HashSet<string>();
            var defaultChanges = new Dictionary<string, string>();

            foreach (Word.Bookmark bookMark in doc.Bookmarks)
            {
                bookMarkNames.Add(bookMark.Name);
                defaultChanges[bookMark.Name] = "";
            }
            doc.Close();

            wrapper.BookmarksNames = bookMarkNames;
            wrapper.Changes = defaultChanges;
            wrapper.FilePath = filePath;
        }
    }
}
