using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace SendEmail.Email.Mapi
{
    public static class MapiAttachment
    {
        public static List<string> AttachmentList { get; } = new List<string>();

        public static void Add(string fileName)
        {
            AttachmentList.Add(fileName);
        }

        public static IntPtr GetAttachments(out int fileCount)
        {
            fileCount = 0;

            if (AttachmentList?.Count == null || AttachmentList.Count <= 0)
                return IntPtr.Zero;

            var attachmentCount = Marshal.SizeOf(typeof(MapiFileDescription));
            var intPtr = Marshal.AllocHGlobal(AttachmentList.Count * attachmentCount);

            var mapiFileDescription = new MapiFileDescription
            {
                position = -1
            };

            var ptr = (int)intPtr;

            foreach (var attachment in AttachmentList)
            {
                mapiFileDescription.name = Path.GetFileName(attachment);
                mapiFileDescription.path = attachment;
                Marshal.StructureToPtr(mapiFileDescription, (IntPtr)ptr, false);
                ptr += attachmentCount;
            }

            fileCount = AttachmentList.Count;

            return intPtr;
        }
    }
}
