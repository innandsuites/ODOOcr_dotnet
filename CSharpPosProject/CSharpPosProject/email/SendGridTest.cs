// using SendGrid's C# Library
// https://github.com/sendgrid/sendgrid-csharp
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace email
{
    internal class SendGridTest
    {
        public void send()
        {
            Execute().Wait();
        }

        public static async Task Execute()
       
        {
            var apiKey = "su_api_key";

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("email@outlook.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("some@gmail.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }
    }
}
