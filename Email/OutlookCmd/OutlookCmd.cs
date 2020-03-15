using System.Diagnostics;
using System.Windows.Forms;

namespace SendEmail.Email.OutlookCmd
{
    public class OutlookCmd
    {
        //Usability: Outlook - O365 for sure may need to test older versions
        //Recipients: Multiple (sep: ;) 
        //Attachments: Single (multi not tested)
        //Signature: In app
        //Send Direct: No
        public void SendMail(Email email)
        {
            var cmdPath = GetCommandPath();
            if (cmdPath is null)
            {
                MessageBox.Show(@"No executable path found.");
                return;
            }

            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe"
                ,
                WorkingDirectory = cmdPath
                ,
                UseShellExecute = false
                ,
                CreateNoWindow = true
                ,
                Arguments = string.IsNullOrWhiteSpace(email.Attachment)
                    ? $"/C outlook.exe -c ipm.note /m \"{email.To}?subject={email.Subject}&body={email.Body}\""
                    : $"/C outlook.exe -c ipm.note /m \"{email.To}?subject={email.Subject}&body={email.Body}\" /a {email.Attachment}"
            };

            process.StartInfo = startInfo;
            process.Start();

        }
        private string GetCommandPath()
        {
            var machine = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\mailto\shell\open\command", "", "none");
            var user = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Classes\mailto\shell\open\command"
                , "", "none");
            const string remove = @"OUTLOOK.EXE"" -c IPM.Note /mailto ""%1""";

            return !(user is null)
                ? user.ToString().Replace(remove, "").Remove(0, 1)
                : machine?.ToString().Replace(remove, "").Remove(0, 1);
        }
    }
}
