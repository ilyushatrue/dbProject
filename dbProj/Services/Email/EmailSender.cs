using Microsoft.AspNetCore.Identity.UI.Services;

namespace dbProj.Services.Email
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //TODO create email services
            await Task.CompletedTask;
        }
    }
}
