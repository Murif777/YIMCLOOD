using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace BILL
{
    public class EmailService
    {
        private string smtpServer = "smtp.gmail.com";
        private int smtpPort = 587;
        private string smtpUser = "yimclood@gmail.com";
        private string smtpPass = "vxpz ujky ojtg rnyl";

        // Método existente sin archivo adjunto
        public void SendEmail(string toEmail, string subject, string body)
        {
            SendEmail(toEmail, subject, body, null);
        }

        // Método sobrecargado con archivo adjunto
        public void SendEmail(string toEmail, string subject, string body, string attachmentPath)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(smtpUser);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                if (!string.IsNullOrEmpty(attachmentPath))
                {
                    Attachment attachment = new Attachment(attachmentPath);
                    mail.Attachments.Add(attachment);
                }

                using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                {
                    smtp.Credentials = new NetworkCredential(smtpUser, smtpPass);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}
