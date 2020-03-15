using SendEmail.Tools;
using System;
using System.Net;
using System.Net.Mail;

namespace SendEmail.Email.Smtp
{
    public class SmtpMail
    {
        //Usability: Works if SMTP information is provided
        //Recipients: Multiple (sep: ;?)
        //Attachments: Single (multi not tested)
        //Signature: No (not verified)
        //Send Direct: Only
        public void SendMail(SmtpMailServer smtpMailServer, Email email)
        {
            var smtpServer = BuildSmtpClient(smtpMailServer);
            var mailMessage = BuildEmailMessage(email);

            Send(mailMessage, smtpServer);
        }
        private static void Send(MailMessage mailMessage, SmtpClient smtpClient)
        {
            if (mailMessage == null)
            {
                return;
            }

            smtpClient.SendCompleted += (s, e) =>
            {
                var callbackClient = s as SmtpClient;
                var callbackMailMessage = e.UserState as MailMessage;
                callbackClient?.Dispose();
                callbackMailMessage?.Dispose();
            };

            smtpClient.SendAsync(mailMessage, mailMessage);
        }
        private static MailMessage BuildEmailMessage(Email email)
        {
            var mailMessage = new MailMessage()
            {
                From = new MailAddress(email.From),
                Subject = email.Subject,
                Body = email.Body
            };

            foreach (var address in email.To.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                mailMessage.To.Add(address);
            }

            if (email.Attachment.Length == 0)
                return mailMessage;

            var attachment = new Attachment(email.Attachment);
            mailMessage.Attachments.Add(attachment);

            return mailMessage;
        }
        private static SmtpClient BuildSmtpClient(SmtpMailServer smtpMailServer)
        {
            var smtpServer = new SmtpClient(smtpMailServer.SmtpServer)
            {
                Port = smtpMailServer.PortNumber,
                Credentials = new NetworkCredential(smtpMailServer.Username, smtpMailServer.Password.ToInsecureString()),
                EnableSsl = smtpMailServer.EnableSsl
            };

            return smtpServer;
        }
    }
}
