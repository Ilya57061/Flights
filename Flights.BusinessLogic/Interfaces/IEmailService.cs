namespace Flights.BusinessLogic.Interfaces
{
    public interface IEmailService
    {
        void Send(string email, string subject, string message);
    }
}
