using Outlook = Microsoft.Office.Interop.Outlook;

namespace SendEmail.Email.OutlookMail
{
    public class OutlookMail
    {
        //Usability: Works only with Outlook
        //Recipients: Multiple (sep: ;) 
        //Attachments: Yes
        //Signature: Adds default signature automatically
        //Send Direct: Available
        public void SendMail(Email email, Checks checks)
        {
            var outlook = new Outlook.Application();

            var mail = (Outlook.MailItem)outlook.CreateItem(Outlook.OlItemType.olMailItem);

            foreach (Outlook.Account account in outlook.Session.Accounts)
            {
                if (account.SmtpAddress == email.From)
                    mail.SendUsingAccount = account;
            }

            mail.Subject = email.Subject;

            mail.Recipients.Add(email.To);
            mail.Recipients.ResolveAll();

            mail.Display(mail);
            mail.HTMLBody = string.Concat(email.Body, mail.HTMLBody);

            if (email.Attachment.Length > 0)
            {
                mail.Attachments.Add(email.Attachment, Outlook.OlAttachmentType.olByValue, 1, email.Attachment);
            }

            if (checks.SendDirect)
                mail.Send();
        }
    }
}
