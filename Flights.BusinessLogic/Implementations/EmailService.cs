using MimeKit;
using MailKit.Net.Smtp;
using Flights.BusinessLogic.Interfaces;

namespace Flights.BusinessLogic.Implementations
{
    public class EmailService:IEmailService
    {
        public void Send(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Travello", "xxxxxx"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);
                 client.Authenticate("xxxxxx", "xxxxxxxxxx");
                client.Send(emailMessage);
                 client.Disconnect(true);
            }
        }
    }
}
