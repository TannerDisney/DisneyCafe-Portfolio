using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace DisneyCafe.Models
{
    public static class SendGridEmailHelper
    {
        public static async Task SendEmailToUser(IConfiguration config, string emailAddress, string subject = "Regarding DisneyCafe", string body = "Automated Message From SendGridApi")
        {
            var apiKey = config.GetSection("SendGridApiKey").Value;
            var client = new SendGridClient(apiKey);
            var doNotReplyEmail = new EmailAddress("INSERT DO NOT REPLY EMAIL");
            EmailAddress recipient = new EmailAddress(emailAddress);
            var htmlContent = $"<strong>DisneyCafe Inc.</strong><br><p>{body}</p>";
            var msg = MailHelper.CreateSingleEmail(doNotReplyEmail, recipient, subject, body, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
