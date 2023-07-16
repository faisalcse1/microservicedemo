using Ordering.Application.Models;

namespace Ordering.Application.Contacts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(Email email);
    }
}
