namespace CitiesInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = "admin@mcompany.com";
        private string _mailFrom = "noreply@mycompany.com";
        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"subject from local: {subject}");
            Console.WriteLine($"message: {message}");
        }
    }
}
