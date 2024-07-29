using FillInApp.GUI;
using FillInApp.Helpers;
using FillInApp.Interfaces;
using System;
using System.Windows.Forms;

namespace FillInApp.Actions
{
    /// <summary>
    /// Отправка заполненного документа на почту
    /// </summary>
    public class SendMailAction : IUserAction
    {
        public void Execute(IOfficeWrapper wrapper)
        {
            if (wrapper == null)
                throw new ArgumentNullException(nameof(wrapper));

            if (string.IsNullOrEmpty(wrapper.DocumentFilePath))
            {
                MessageBox.Show("Сперва сохраните документ");
                return;
            }

            var mailTo = string.Empty;
            using (var frmMailTo = new MailToForm())
            {
                if (frmMailTo.ShowDialog() != DialogResult.OK)
                    return;

                mailTo = frmMailTo.GetMailTo();
            }

            MailHelper.Send(mailTo, wrapper.DocumentFilePath);
            MessageBox.Show("Письмо было отправлено");
        }
    }
}
