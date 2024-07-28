using System;
using System.Windows.Forms;

namespace FillInApp.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fillInWordButton_Click(object sender, EventArgs e)
        {
            using (var frm = new WordOfficeWrapperForm())
                frm.ShowDialog();

            //Form frm = null;
            //try
            //{
            //    frm = new WordOfficeWrapperForm();
            //    frm.ShowDialog();
            //}
            //finally
            //{
            //    frm?.Dispose();
            //    WordOfficeHelper.ResetCache();
            //}
        }
    }
}
