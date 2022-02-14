using System.Configuration;
using Telegram.Bot;

namespace Consultant.Bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];

            if (string.IsNullOrEmpty(apiKey))
            {
                Environment.Exit(69);
            }

            var bot = new TelegramBotClient(apiKey);

            new Model.BotManager(bot);

            var me = await bot.GetMeAsync();

            Console.WriteLine($"@{me.Username} inited");

            Console.ReadKey();

            await bot.CloseAsync();
        }
    }
}