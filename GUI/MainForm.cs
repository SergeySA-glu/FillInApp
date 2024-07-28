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

        private void FillInWordButton_Click(object sender, EventArgs e)
        {
            using (var frm = new WordOfficeWrapperForm())
                frm.ShowDialog();
        }
    }
}
