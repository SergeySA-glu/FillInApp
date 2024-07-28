using FillInApp.Interfaces;

namespace FillInApp.Actions
{
    /// <summary>
    /// Загрузка данных из шаблона для изменения
    /// </summary>
    public class SaveChangesAction : IUserAction
    {
        public void Execute(IOfficeWrapper wrapper)
        {
            // выбор файла
            //var filePath = FileHelper.GetFilePath();

            //var doc = WordOfficeHelper.Application.Documents.Add(filePath);

            //var bookMarkNames = new HashSet<string>();
            //var defaultChanges = new Dictionary<string, string>();
            //foreach (Word.Bookmark bookMark in doc.Bookmarks)
            //{
            //    bookMarkNames.Add(bookMark.Name);
            //    defaultChanges[bookMark.Name] = "";
            //}
            //wrapper.BookmarksNames = bookMarkNames;
            //wrapper.Changes = defaultChanges;
        }
    }
}
