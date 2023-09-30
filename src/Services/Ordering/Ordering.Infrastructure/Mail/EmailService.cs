using Ordering.Application.Contacts.Infrastructure;
using Ordering.Application.Models;
using QuickMailer;

namespace Ordering.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        public async Task<bool> SendEmailAsync(EmailMessage emailMessage)
        {
            Email email = new Email();
            if(email.IsValidEmail(emailMessage.To))
            {
                return email.SendEmail(emailMessage.To, EmailCredential.EmailAddress,EmailCredential.Password, emailMessage.Subject, emailMessage.Body);
            }
            return false;
            
        }
    }
}
