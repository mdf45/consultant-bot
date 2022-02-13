using Consultant.Bot.Data;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Consultant.Bot.Model
{
    public class BotManager
    {
        public TelegramBotClient Bot { get; }

        public BotManager(TelegramBotClient bot)
        {
            Bot = bot;

            var receivedOptions = new ReceiverOptions
            {
                AllowedUpdates = { }
            };

            Bot.StartReceiving(HandleUpdateAsync, HandleErrorAsync, receivedOptions);
        }

        async Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                var msg = update.Message;
                var userId = msg.From.Id;

                if (BotData.LastButton.ContainsKey(userId) && BotData.LastButton[userId] == "search")
                {
                    await bot.DeleteMessageAsync(msg.Chat.Id, msg.MessageId, cancellationToken: cancellationToken);

                    string text = "Список продуктов пуст!", textFound = "Ничего не найдено";

                    try
                    {
                        var products = await Api.GetProductsByKeywordsAsync(msg.Text, cancellationToken);

                        var count = products.Count;

                        if (count > 0)
                            textFound = $"Найдено товаров: {count}";

                        text = $"Ключевое слово: '{msg.Text}'" +
                        $"\n{textFound}" +
                        $"\n\n";
                        text += BotData.GetProductsText(products);
                    }
                    catch
                    {

                    }
                    
                    if (BotData.LastCallback.ContainsKey(userId))
                    {
                        var callback = BotData.LastCallback[userId];

                        await bot.EditMessageTextAsync(msg.Chat.Id, callback.Message.MessageId, text, parseMode: ParseMode.Html, replyMarkup: BotData.BackMarkup, cancellationToken: cancellationToken);
                        await bot.AnswerCallbackQueryAsync(callback.Id, textFound, cancellationToken: cancellationToken);
                    }
                    else 
                    {
                        await bot.SendTextMessageAsync(msg.Chat.Id, text, replyMarkup: BotData.MainMarkup, cancellationToken: cancellationToken);
                    }

                    BotData.LastButton[userId] = null;
                }
                else if (msg.Text == "/start")
                {
                    await bot.SendTextMessageAsync(msg.Chat.Id, BotData.GetMainMenuText(msg.From), replyMarkup: BotData.MainMarkup, cancellationToken: cancellationToken);
                }
            }
            else if (update.Type == UpdateType.CallbackQuery)
            {
                var cb = update.CallbackQuery;

                await BotData.AllButtons[cb.Data].Callback(bot, cb);
                BotData.LastButton[cb.From.Id] = cb.Data;
                BotData.LastCallback[cb.From.Id] = cb;
            }
        }

        Task HandleErrorAsync(ITelegramBotClient bot, Exception exception, CancellationToken cancellationToken)
        {
            try
            {
                var errorMessage = exception switch
                {
                    ApiRequestException apiRequestException
                        => $"Telegram API Error:\n{apiRequestException.ErrorCode}\n{apiRequestException.Message}",
                    _ => exception.ToString()
                };

                Console.WriteLine(errorMessage);
            }
            catch { }

            return Task.CompletedTask;
        }
    }
}
