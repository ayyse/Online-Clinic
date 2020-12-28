using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Online_Clinic.Common.EmailOperationModels
{
    //public class EmailSender : IEmailSender
    //{
    //    private readonly EmailOptions _emailOptions;
    //    public EmailSender(IOptions<EmailOptions> options)
    //    {
    //        _emailOptions = options.Value;
    //    }

    //    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    //    {
    //        return Execute(_emailOptions.SendGridApiKey, subject, htmlMessage, email);
    //    }

    //    private Task Execute(string SendGridApiKey, string subject, string message, string email)
    //    {
    //        var client = new SendGridClient(SendGridApiKey);
    //        var from = new EmailAddress("ayseakisik16@gmail.com", "Online-Clinic");
    //        var to = new EmailAddress(email, "Son Kullanıcı");
    //        var msg = MailHelper.CreateSingleEmail(from, to, subject, "", message);
    //        return client.SendEmailAsync(msg);
    //    }
    //}
}
