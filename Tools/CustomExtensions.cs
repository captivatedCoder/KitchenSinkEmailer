﻿using System.Runtime.InteropServices;
using System.Security;

namespace SendEmail.Tools
{
    public static class CustomExtensions
    {
        public static SecureString ToSecureString(this string input)
        {
            var secure = new SecureString();

            foreach (var c in input)
            {
                secure.AppendChar(c);
            }

            secure.MakeReadOnly();

            return secure;
        }

        public static string ToInsecureString(this SecureString input)
        {
            var returnValue = string.Empty;
            var ptr = Marshal.SecureStringToBSTR(input);

            try
            {
                returnValue = Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(ptr);
            }

            return returnValue;
        }
    }
}