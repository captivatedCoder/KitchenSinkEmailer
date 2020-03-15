using System.Diagnostics;
using System.IO;

namespace SendEmail.Email.MailTo
{
    public class MailTo
    {
        //Usability: Outlook, Thunderbird, Win10 Mail App
        //Recipients: Multiple (sep: ;) 
        //Attachments: No
        //Signature: In app
        //Send Direct: No
        public static void SendMail(Email email)
        {
            var mailto = string.IsNullOrWhiteSpace(email.Attachment)
                ? $"mailto:{email.To}?Subject={email.Subject}&Body={email.Body}"
                : $"mailto:{email.To}?Subject={email.Subject}&Body={email.Body}&Attachment={Path.GetFullPath(email.Attachment)}";

            Process.Start(mailto);
        }
    }
}
