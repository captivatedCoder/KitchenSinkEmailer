using System.Security;

namespace SendEmail.Email.Smtp
{
    public class SmtpMailServer
    {
        public string SmtpServer { get; set; }
        public int PortNumber { get; set; }
        public bool EnableSsl { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }
    }
}
