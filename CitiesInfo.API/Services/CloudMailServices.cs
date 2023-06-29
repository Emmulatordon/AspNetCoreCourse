namespace CitiesInfo.API.Services
{
    public class CloudMailServices : IMailService
    {
        private string _mailTo = "admin@mcompany.com";
        private string _mailFrom = "noreply@mycompany.com";
        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(CloudMailServices)}.");
            Console.WriteLine($"subject from cloud: {subject}");
            Console.WriteLine($"message: {message}");
        }
    }
}
