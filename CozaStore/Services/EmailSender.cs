using SendGrid;
using SendGrid.Helpers.Mail;

namespace CozaStore.Services;

public class EmailSender : IEmailSender
{
    public EmailSender()
    {
    }

    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        string apiKey = "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";
        var client = new SendGridClient(apiKey);
        var from = new EmailAddress("gallojunior@gmail.com", "GalloFlix");
        var to = new EmailAddress(email, "Usuário");
        var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlMessage, htmlMessage);
        await client.SendEmailAsync(msg);
    }
}
