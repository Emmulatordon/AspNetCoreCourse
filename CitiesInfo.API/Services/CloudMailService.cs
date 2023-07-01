namespace CitiesInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = string.Empty;
        private string _mailFrom = string.Empty;
        public CloudMailService(IConfiguration config)
        {
            _mailFrom = config["mailSettings:mailFromAddress"];
            _mailTo = config["mailSettings:mailToAddress"];
        }
        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(CloudMailService)}.");
            Console.WriteLine($"subject from cloud: {subject}");
            Console.WriteLine($"message: {message}");
        }
    }
}
