using FillInApp.Helpers;
using System.Windows.Forms;

namespace FillInApp.GUI
{
    public partial class MailToForm : Form
    {
        public MailToForm()
        {
            InitializeComponent();
        }

        public string GetMailTo() => textMailTo.Text.Trim();

        private void FrmRename_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                e.Cancel = !MailHelper.MailToValidate(GetMailTo());
            }
        }
    }
}
