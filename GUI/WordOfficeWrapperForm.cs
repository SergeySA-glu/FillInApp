using FillInApp.Actions;
using FillInApp.Helpers;
using FillInApp.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FillInApp
{
    public partial class WordOfficeWrapperForm : Form
    {
        private readonly IOfficeWrapper _wrapper;
        private readonly IUserAction _downloadAction;
        private readonly IUserAction _uploadAction;
        private readonly IUserAction _sendMailAction;

        public WordOfficeWrapperForm()
        {
            InitializeComponent();
            _wrapper = new WordOfficeWrapper();
            _downloadAction = new DownloadAction();
            _uploadAction = new UploadAction();
            _sendMailAction = new SendMailAction();
        }

        private void InitBookmarksTable()
        {
            var bookmarks = _wrapper.BookmarksNames.ToList();
            bookmarks.Reverse();

            bookmarksTable.Controls.Clear();
            bookmarksTable.RowCount = 0;

            for (int i = 0; i < bookmarks.Count; i++)
            {
                var lbl = new Label { Text = bookmarks[i] };
                lbl.Dock = DockStyle.Fill;
                lbl.Margin = new Padding(3, 3, 3, 3);
                var textEdit = new TextBox();
                textEdit.Dock = DockStyle.Fill;
                textEdit.Tag = lbl;
                textEdit.TextChanged += TextEdit_TextChanged;

                this.bookmarksTable.RowCount++;
                this.bookmarksTable.Size = new System.Drawing.Size(this.bookmarksTable.Size.Width, this.bookmarksTable.Size.Height + 100);
                this.bookmarksTable.RowStyles.Add(new RowStyle(SizeType.AutoSize, 50F));

                bookmarksTable.Controls.Add(lbl, 0, i);
                bookmarksTable.Controls.Add(textEdit, 1, i);
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            _downloadAction.Execute(_wrapper);
            InitBookmarksTable();
        }

        private void SendMailButton_Click(object sender, EventArgs e)
        {
            _sendMailAction.Execute(_wrapper);
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            _uploadAction.Execute(_wrapper);
        }

        private void WordOfficeWrapperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WordOfficeHelper.ResetWordApplication();
        }

        private void TextEdit_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox editor && editor.Tag is Label lbl)
                _wrapper.Changes[lbl.Text] = editor.Text;
        }

        private void BookmarksTable_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.Dispose();
        }
    }
}
