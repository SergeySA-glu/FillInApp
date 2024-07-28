using FillInApp.Helpers;
using FillInApp.Interfaces;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Forms;

namespace FillInApp.Actions
{
    public class UploadAction : IUserAction
    {
        public void Execute(IOfficeWrapper wrapper)
        {
            var doc = WordOfficeHelper.Application.Documents.Add(wrapper.FilePath);

            foreach (Bookmark bookmark in doc.Bookmarks)
            {
                if (wrapper.Changes.TryGetValue(bookmark.Name, out string newText))
                    bookmark.Range.Text = newText;
            }

            using (var fileDialog = new SaveFileDialog())
            {
                fileDialog.InitialDirectory = Path.GetDirectoryName(wrapper.FilePath);
                fileDialog.Filter = "Файлы шаблонов (*.doc)|*.doc| Файлы шаблонов (*.docx)|*.docx";
                fileDialog.AddExtension = true;
                fileDialog.FileName = "Заполненный документ";

                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return;

                var filename = fileDialog.FileName;
                doc.SaveAs2(FileName: filename);
                doc.Close();
            }
        }
    }
}
