﻿namespace CitiesInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = string.Empty;
        private string _mailFrom = string.Empty;
        public LocalMailService(IConfiguration config)
        {
            _mailFrom = config["mailSettings:mailFromAddress"];
            _mailTo = config["mailSettings:mailToAddress"];
        }
        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"subject from local: {subject}");
            Console.WriteLine($"message: {message}");
        }
    }
}
