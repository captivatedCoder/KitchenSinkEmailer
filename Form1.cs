using System;
using System.Windows.Forms;
using SendEmail.Email.OutlookMail;
using SendEmail.Email.Smtp;
using SendEmail.Tools;

namespace SendEmail
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            var email = GetEmail();
            var mailServer = new SmtpMailServer();

            if (email is null)
                return;
            if (SmtpChk.Checked)
                mailServer = GetSmtpServer();
            Emailer.SendMail(email, mailServer, GetChecks());
        }
        private SmtpMailServer GetSmtpServer()
        {
            return new SmtpMailServer()
            {
                SmtpServer = SmtpServerUrl.Text,
                PortNumber = int.Parse(PortNumber.Text),
                EnableSsl = true,
                Username = Username.Text,
                Password = Password.Text.ToSecureString()
            };
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == attachmentDialog.ShowDialog())
                Attachments.Text = attachmentDialog.FileName;
        }
        private Email.Email GetEmail()
        {
            var email = new Email.Email
            {
                From = FromBox.Text,
                To = ToBox.Text,
                Subject = SubjectBox.Text,
                Body = MessageText.Text,
                Attachment = Attachments.Text,
            };

            if (!string.IsNullOrWhiteSpace(PortNumber.Text) || !SmtpChk.Checked)
                return email;

            PortNumber.Focus();
            return null;

        }
        private Checks GetChecks()
        {
            var checks = new Checks()
            {
                MailTo = MailToChk.Checked,
                Mapi = MapiChk.Checked,
                Outlook = OutlookChk.Checked,
                Smtp = SmtpChk.Checked,
                OutlookAlt = OutlookCmdChk.Checked,
                TbirdAlt = TbirdChk.Checked,
                AddCrlf = CrLfChk.Checked,
                SendDirect = SendDirect.Checked
            };

            return checks;
        }
        private void OtherBtn_Click(object sender, EventArgs e)
        {
            var machine = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\mailto\shell\open\command", "", "none");
            var user = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Classes\mailto\shell\open\command", "", "none");

            if (machine is null && !(user is null))
                MessageBox.Show($"No Machine Key\n\nUser Key: {user}");
            else if (!(machine is null) && user is null)
                MessageBox.Show($"Machine Key: {machine}\n\nNo User Key\n\n{machine.ToString().Substring(0, machine.ToString().Length - 4)}");
            else if (machine is null && user is null)
                MessageBox.Show("No Keys");
            else
                MessageBox.Show($"Machine Key: {machine}\n\nUser Key: {user}\n\n{machine.ToString().Substring(0, machine.ToString().Length - 4)}");
        }

        private void ToBtn_Click(object sender, EventArgs e)
        {
            if (OutlookChk.Checked || OutlookCmdChk.Checked)
            {
                var to = AddressBook.GetAddressBook();
                ToBox.Text = to.Name;
            }
            else
                ToBox.Focus();
        }
    }
}
