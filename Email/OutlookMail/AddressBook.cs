using Outlook = Microsoft.Office.Interop.Outlook;

namespace SendEmail.Email.OutlookMail
{
    public static class AddressBook
    {
        public static Recipient GetAddressBook()
        {
            var outlook = new Outlook.Application();

            var outlookDialog = outlook.Session.GetSelectNamesDialog();
            outlookDialog.NumberOfRecipientSelectors = Outlook.OlRecipientSelectors.olShowTo;
            outlookDialog.ForceResolution = true;

            if (!outlookDialog.Display()) return null;

            var recipients = outlookDialog.Recipients;

            var recipient = new Recipient()
            {
                Name = recipients[1].Name,
                Address = recipients[1].Address
            };

            return recipient;
        }

    }
}
