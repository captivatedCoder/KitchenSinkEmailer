using SendEmail.Email.MailTo;
using SendEmail.Email.Mapi;
using SendEmail.Email.OutlookMail;
using SendEmail.Email.Smtp;
using System.Windows.Forms;
using SendEmail.Email.OutlookCmd;
using SendEmail.Email.TbirdCmd;

namespace SendEmail
{
    public static class Emailer
    {
        public static void SendMail(Email.Email email, SmtpMailServer mailServer, Checks checks)
        {
            if (checks.MailTo)
                SendUsingMailTo(email);
            else if (checks.Mapi)
                SendUsingMapiMail(email, checks);
            else if (checks.Outlook)
                SendUsingOutlook(email, checks);
            else if (checks.Smtp)
                SendUsingSmtp(email, mailServer);
            else if (checks.OutlookAlt)
                SendUsingOutlookCmd(email);
            else if (checks.TbirdAlt)
                SendUsingTbirdAlt(email);
        }

        private static void SendUsingTbirdAlt(Email.Email email)
        {
            var tCmd = new TbirdCmd();
            tCmd.SendMail(email);
        }

        private static void SendUsingOutlookCmd(Email.Email email)
        {
            var oCmd = new OutlookCmd();
            oCmd.SendMail(email);
        }
        private static void SendUsingSmtp(Email.Email email, SmtpMailServer mailServer)
        {
            var smtpMail = new SmtpMail();
            smtpMail.SendMail(mailServer, email);
        }
        private static void SendUsingOutlook(Email.Email email, Checks checks)
        {
            var oMail = new OutlookMail();

            oMail.SendMail(email, checks);
        }
        private static void SendUsingMailTo(Email.Email email)
        {
            MailTo.SendMail(email);
        }
        private static void SendUsingMapiMail(Email.Email email, Checks checks)
        {
            var mailer = new MapiMail();

            int? result = mailer.SendMail(email, checks);

            if (result == 0)
                MessageBox.Show("Mail sent successfully");
        }
    }
}
