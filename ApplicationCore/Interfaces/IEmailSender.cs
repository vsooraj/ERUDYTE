using System.Threading.Tasks;

namespace Erudyte.ApplicationCore.Interfaces
{
    public interface IEmailSender
    {

        Task SendEmailAsync(string email, string subject, string message);

    }
}
