using FillInApp.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace FillInApp.Actions
{
    /// <summary>
    /// Отправка заполненного документа на почту
    /// </summary>
    public class SendMailAction : IUserAction
    {
        public async void Execute(IOfficeWrapper wrapper)
        {
            if (string.IsNullOrEmpty(wrapper.DocumentFilePath))
            {
                MessageBox.Show("Сперва сохраните документ");
                return;
            }

            // здесь должна быть формочка ввода почты, с проверкой желательно

            MailAddress from = new MailAddress("totoroanigiri@yandex.ru", "FillInApp");
            MailAddress to = new MailAddress("glukchek@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Attachments.Add(new Attachment(wrapper.DocumentFilePath));
            m.Subject = "Зполненный документ";
            m.Body = "Приложение FillInApp сформировало и прислало заполненный по шаблону документ на Вашу почту";
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("totoroanigiri@yandex.ru", "blmoutyolcmvffbb");
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
            MessageBox.Show("Письмо было отправлено");
        }
    }
}
