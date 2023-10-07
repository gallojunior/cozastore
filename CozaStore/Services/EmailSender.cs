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
        var from = new EmailAddress("gallojunior@gmail.com", "CozaStore");
        var to = new EmailAddress(email, "Usuário");
        var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlMessage, htmlMessage);
        await client.SendEmailAsync(msg);
    }
}
