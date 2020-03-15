namespace SendEmail
{
    public class Checks
    {
        public bool MailTo { get; set; }
        public bool Mapi { get; set; }
        public bool Outlook { get; set; }
        public bool Smtp { get; set; }
        public bool OutlookAlt { get; set; }
        public bool TbirdAlt { get; set; }
        public bool SendDirect { get; set; }
        public bool AddCrlf { get; set; }
    }
}