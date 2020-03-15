using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SendEmail.Email.Mapi
{
    public static class MapiRecipient
    {
        public static List<MapiRecipientDescription> GetRecipientList { get; } = new
            List<MapiRecipientDescription>();

        public static bool AddRecipient(string emailAddress, MapiMail.RecipientType toWhom)
        {
            var recipient = new MapiRecipientDescription()
            {
                recipClass = (int)toWhom,
                name = emailAddress
            };

            GetRecipientList.Add(recipient);

            return true;
        }

        public static IntPtr GetRecipients(out int recipientCount)
        {
            recipientCount = 0;

            if (GetRecipientList.Count == 0)
                return IntPtr.Zero;

            var listSize = Marshal.SizeOf(typeof(MapiRecipientDescription));
            var intPtr = Marshal.AllocHGlobal(GetRecipientList.Count * listSize);

            var ptr = (int)intPtr;

            foreach (var recipient in GetRecipientList)
            {
                Marshal.StructureToPtr(recipient, (IntPtr)ptr, false);
                ptr += listSize;
            }

            recipientCount = GetRecipientList.Count;

            return intPtr;
        }
    }
}
