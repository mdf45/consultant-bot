using Consultant.Bot.Entity;
using Consultant.Shared.Entity.Api;
using Consultant.Bot.Model;
using System.Configuration;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Consultant.Bot.Data
{
    public static class BotData
    {
        private static int MaxButtonsInRow { get; }

        public static InlineKeyboardMarkup MainMarkup { get; }
        public static InlineKeyboardMarkup BackMarkup { get; }

        public static Dictionary<long, string> LastButton { get; } = new();
        public static Dictionary<long, CallbackQuery> LastCallback { get; } = new();

        public static Dictionary<string, Button> MainButtons { get; } = new()
        {
            {
                "list",
                new()
                {
                    Text = "Список товаров 📋",
                    Callback = async (bot, callback) =>
                    {
                        var msg = callback.Message;

                        var text = $"Список продуктов пуст!";

                        IList<Product> products = null;

                        try
                        {
                            products = await Api.GetProductsAsync();

                            if (products.Count > 0)
                            {
                                text = "Список товаров:\n\n";

                                text += GetProductsText(products);
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        await bot.EditMessageTextAsync(msg.Chat.Id, msg.MessageId, text, parseMode: ParseMode.Html, replyMarkup: BackMarkup);
                        await bot.AnswerCallbackQueryAsync(callback.Id, "Успешно");
                    }
                }
            },
            {
                "search",
                new()
                {
                    Text = "Поиск 🔍",
                    Callback = async (bot, callback) =>
                    {
                        var msg = callback.Message;

                        var text = $"Введите ключевое слово, для того чтобы найти товары";

                        await bot.EditMessageTextAsync(msg.Chat.Id, msg.MessageId, text, replyMarkup: BackMarkup);
                    }
                }
            },
            {
                "info",
                new()
                {
                    Text = "Информация 👨‍💻",
                    Callback = async (bot, callback) =>
                    {
                        var msg = callback.Message;
                        var text = "Данный бот был разработан для прохождения производственной практики на предприятии ООО \"Легион\"\n© Резинкин Иван";

                        await bot.EditMessageTextAsync(msg.Chat.Id, msg.MessageId, text, replyMarkup: BackMarkup);
                    }
                }
            }
        };
        public static Dictionary<string, Button> BackButtons { get; } = new()
        {
            {
                "back",
                new()
                {
                    Text = "<< Назад",
                    Callback = async (bot, callback) =>
                    {
                        var msg = callback.Message;

                        var text = GetMainMenuText(callback.From);

                        await bot.EditMessageTextAsync(msg.Chat.Id, msg.MessageId, text, replyMarkup: MainMarkup);
                    }
                }
            }
        };
        public static Dictionary<string, Button> AllButtons { get; }

        static BotData()
        {
            var parsed = int.TryParse(ConfigurationManager.AppSettings["MaxButtonsInRow"], out int maxButtonsInRow);

            if (parsed && maxButtonsInRow > 0)
            {
                MaxButtonsInRow = maxButtonsInRow;
            }
            else
            {
                MaxButtonsInRow = 2;
            }

            MainMarkup = InitMarkup(MainButtons);
            BackMarkup = InitMarkup(BackButtons);

            AllButtons = MainButtons.Union(BackButtons).ToDictionary(x => x.Key, x => x.Value);
        }

        public static string GetMainMenuText(User user) => $"Добро пожаловать, {user.FirstName}!" +
            $"\nВыбери действие:";

        public static string GetProductsText(IEnumerable<Product> products)
        {
            var text = string.Empty;

            if (products == null || !products.Any()) return text;

            foreach (var product in products)
            {
                text += $"{product.Name}\nЦена: {product.Price:F2} ₽\n\n";
            }

            return text;
        }

        private static InlineKeyboardMarkup InitMarkup(Dictionary<string, Button> buttons)
        {
            var buttonList = new List<List<InlineKeyboardButton>>();

            var keys = buttons.Keys.ToArray();

            for (int i = 0; i < buttons.Count; i++)
            {
                if (i % MaxButtonsInRow == 0)
                {
                    buttonList.Add(new List<InlineKeyboardButton>());
                }

                var key = keys[i];

                var btn = buttons[key];

                buttonList[^1].Add(new(btn.Text)
                {
                    CallbackData = key
                });
            }

            return new(buttonList);
        }
    }
}
