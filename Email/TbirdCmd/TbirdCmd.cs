using System.Diagnostics;
using System.Windows.Forms;

namespace SendEmail.Email.TbirdCmd
{
    public class TbirdCmd
    {
        //Usability: Thunderbird
        //Recipients: Multiple (sep: ,)
        //Attachments: Multiple (sep: ,)
        //Signature: Yes
        //Send Direct: 
        public void SendMail(Email email)
        {
            var cmdPath = GetCommandPath();
            if (cmdPath is null)
            {
                MessageBox.Show(@"No executable path found.");
                return;
            }

            var process = new Process();
            var startInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                WorkingDirectory = cmdPath,
                UseShellExecute = false,
                Arguments = string.IsNullOrWhiteSpace(email.Attachment)
                    ? $"/C thunderbird -compose \"format=1,to='{email.To}',subject='{email.Subject}',body='{email.Body}'\""
                    : $"/C thunderbird -compose \"format=1,to='{email.To}',subject='{email.Subject}',body='{email.Body}',attachment='{email.Attachment}'\""
            };

            process.StartInfo = startInfo;
            process.Start();
        }

        private string GetCommandPath()
        {
            var machine = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\mailto\shell\open\command", "", "none");
            var user = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Classes\mailto\shell\open\command"
                , "", "none");
            const string remove = @"thunderbird.exe"" -osint -compose ""%1""";

            return !(user is null)
                ? user.ToString().Replace(remove, "").Remove(0, 1)
                : machine?.ToString().Replace(remove, "").Remove(0, 1);
        }
    }
}
