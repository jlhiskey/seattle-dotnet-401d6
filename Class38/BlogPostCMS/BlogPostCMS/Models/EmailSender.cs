using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace BlogPostCMS.Models
{
    public class EmailSender : IEmailSender
    {
        private IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SendGridClient client = new SendGridClient(_configuration["Sendgrid_Api_Key"]);

            SendGridMessage msg = new SendGridMessage();

            msg.SetFrom("noreply@AmandasBlog.com", "Amanda's Blog Admin");

            msg.AddTo(email);
            msg.SetSubject("Welcome to my store");
            msg.AddContent(MimeType.Html, htmlMessage);

            await client.SendEmailAsync(msg);


        }
    }
}
