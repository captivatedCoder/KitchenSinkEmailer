using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SendEmail.Email.Mapi
{
    public class MapiMail
    {
        //Usability: Outlook and Thunderbird
        //Recipients: Multiple (sep: ;) 
        //Attachments: Multiple (call AddAttachment for each file)
        //Signature: In app
        //Send Direct: Yes
        public bool AddRecipientTo(string email)
        {
            return MapiRecipient.AddRecipient(email, RecipientType.To);
        }
        public void AddAttachment(string strAttachmentFileName)
        {
            MapiAttachment.Add(strAttachmentFileName);
        }

        public int SendMail(Email email, Checks checks)
        {
            var message = BuildMapiMessage(email, checks);

            var lastError = MAPISendMail(new IntPtr(0), new IntPtr(0), message, checks.SendDirect ? MapiLogonUi : MapiDialog, 0);

            if (lastError > 1)
                MessageBox.Show($@"Failure sending email: {MapiError.GetLastError(lastError)}");

            return lastError;
        }

        private MapiMessage BuildMapiMessage(Email email, Checks checks)
        {
            //Throws error if To is empty either 2 or 25
            if (!string.IsNullOrWhiteSpace(email.To))
                AddRecipientTo(email.To);

            if (!string.IsNullOrWhiteSpace(email.Attachment))
                AddAttachment(email.Attachment);

            var message = new MapiMessage
            {
                subject = email.Subject,
                //Add CRLF in an attempt to move cursor placement in open email message
                noteText = checks.AddCrlf ? $"{email.Body} {Environment.NewLine}" : email.Body
            };

            message.recipients = MapiRecipient.GetRecipients(out message.recipientCount);
            message.files = MapiAttachment.GetAttachments(out message.fileCount);

            return message;
        }

        [DllImport("MAPI32.DLL")]
        private static extern int MAPISendMail(IntPtr sess, IntPtr hwnd, MapiMessage message, int flg, int rsv);

        private const int MapiLogonUi = 0x1;
        private const int MapiDialog = 0x8;

        public enum RecipientType
        {
            To = 1
            , Cc = 2
            , Bcc = 3
        };
    }
}
