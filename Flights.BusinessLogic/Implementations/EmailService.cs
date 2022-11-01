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

            emailMessage.From.Add(new MailboxAddress("Travello", "johndavid57061@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);
                 client.Authenticate("johndavid57061@gmail.com", "cxhtzptdqmjeigeb");
                client.Send(emailMessage);
                 client.Disconnect(true);
            }
        }
    }
}
