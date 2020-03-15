namespace SendEmail.Email.Mapi
{
    public static class MapiError
    {
        public static string GetLastError(int lastError)
        {
            return lastError <= 26 ? Errors[lastError] : $"MAPI error [{lastError.ToString()}]";
        }

        private static readonly string[] Errors = {
            "OK [0]", "User abort [1]", "General MAPI failure [2]", "MAPI login failure [3]", "Disk full [4]"
            , "Insufficient memory [5]", "Access denied [6]", "-unknown- [7]", "Too many sessions [8]"
            , "Too many files were specified [9]", "Too many recipients were specified [10]"
            , "A specified attachment was not found [11]", "Attachment open failure [12]"
            , "Attachment write failure [13]", "Unknown recipient [14]", "Bad recipient type [15]", "No messages [16]"
            , "Invalid message [17]", "Text too large [18]", "Invalid session [19]", "Type not supported [20]"
            , "A recipient was specified ambiguously [21]", "Message in use [22]", "Network failure [23]"
            , "Invalid edit fields [24]", "Invalid recipients [25]", "Not supported [26]"
        };
    }
}
