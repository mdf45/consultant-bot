using Telegram.Bot;
using Telegram.Bot.Types;

namespace Consultant.Bot.Entity
{
    public class Button
    {
        public string Text { get; init; }
        public Func<ITelegramBotClient, CallbackQuery, Task> Callback { get; init; }
    }
}
