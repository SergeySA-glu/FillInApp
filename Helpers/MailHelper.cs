using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FillInApp.Helpers
{
    public static class MailHelper
    {
        public static async void Send(string mailTo, string attachment)
        {
            var from = new MailAddress("totoroanigiri@yandex.ru", "FillInApp");
            var to = new MailAddress(mailTo);

            var message = new MailMessage(from, to);
            message.Attachments.Add(new Attachment(attachment));
            message.Subject = "Зполненный документ";
            message.Body = "Приложение FillInApp сформировало и прислало заполненный по шаблону документ на Вашу почту";

            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("totoroanigiri@yandex.ru", "blmoutyolcmvffbb");
            smtp.EnableSsl = true;

            await smtp.SendMailAsync(message);
        }

        public static bool MailToValidate(string mailTo)
        {
            if (string.IsNullOrWhiteSpace(mailTo) || !Regex.IsMatch(mailTo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Укажите почтовый адрес");
                return false;
            }
            return true;
        }
    }
}
