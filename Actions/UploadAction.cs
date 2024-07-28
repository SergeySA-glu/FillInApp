using FillInApp.Helpers;
using FillInApp.Interfaces;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace FillInApp.Actions
{
    public class UploadAction : IUserAction
    {
        public void Execute(IOfficeWrapper wrapper)
        {
            var filePath = string.Empty;
            try
            {
                filePath = FileHelper.GetDocumentFilePath(wrapper);
                if (filePath == null)
                    return;

                var doc = WordOfficeHelper.Application.Documents.Add(wrapper.PatternFilePath);

                foreach (Bookmark bookmark in doc.Bookmarks)
                {
                    if (wrapper.Changes.TryGetValue(bookmark.Name, out string newText))
                        bookmark.Range.Text = newText;
                }

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
