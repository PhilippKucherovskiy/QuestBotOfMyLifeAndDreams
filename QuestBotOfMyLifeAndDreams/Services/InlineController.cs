using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using QuestBotOfMyLifeAndDreams.Configuration;
using Telegram.Bot.Types;

namespace QuestBotOfMyLifeAndDreams.Services
{
    public class InlineController : IInlineController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly GameDictionary _gameDictionary;

        public InlineController(ITelegramBotClient telegramBotClient, GameDictionary gameDictionary)
        {
            _telegramClient = telegramBotClient;
            _gameDictionary = gameDictionary;
        }

        public async Task Handle(CallbackQuery callbackQuery)
        {
            var blockId = callbackQuery.Data;
            var gameContent = _gameDictionary.GetGameContent(blockId);

            if (gameContent.Options != null && gameContent.Options.Length > 0)
            {
                var replyMarkup = new InlineKeyboardMarkup(
                    gameContent.Options.Select(option =>
                        InlineKeyboardButton.WithCallbackData(option.Text, option.NextBlock)
                    )
                );

                await _telegramClient.SendTextMessageAsync(
                    chatId: callbackQuery.Message.Chat.Id,
                    text: "Choose an option:",
                    replyMarkup: replyMarkup
                );
            }
        }
    }
}
