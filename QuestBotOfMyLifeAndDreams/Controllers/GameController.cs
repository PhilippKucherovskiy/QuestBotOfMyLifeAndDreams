using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using QuestBotOfMyLifeAndDreams.Services;

namespace QuestBotOfMyLifeAndDreams.Controllers
{
    public class GameController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly GameDictionary _gameDictionary;
        private readonly IInlineController _inlineController;

        public GameController(ITelegramBotClient telegramBotClient, GameDictionary gameDictionary, IInlineController inlineController)
        {
            _telegramClient = telegramBotClient;
            _gameDictionary = gameDictionary;
            _inlineController = inlineController;
        }

        public async Task Handle(Update update)
        {
            if (update.Type == UpdateType.CallbackQuery && update.CallbackQuery != null)
            {
                var callbackQuery = update.CallbackQuery;
                await HandleUserChoice(callbackQuery);
            }
        }

        private async Task HandleUserChoice(CallbackQuery callbackQuery)
        {
            var blockId = callbackQuery.Data;
            var gameContent = _gameDictionary.GetGameContent(blockId);

            if (gameContent != null && !string.IsNullOrEmpty(gameContent.Text) && gameContent.Options != null && gameContent.Options.Length > 0)
            {
                var replyMarkup = new InlineKeyboardMarkup(
                    gameContent.Options.Select(option =>
                        InlineKeyboardButton.WithCallbackData(option.Text, option.NextBlock)
                    )
                );

                await _telegramClient.SendTextMessageAsync(
                    chatId: callbackQuery.Message.Chat.Id,
                    text: gameContent.Text,
                    replyMarkup: replyMarkup
                );

                // Pass the callbackQuery to the InlineController for further handling
                await _inlineController.Handle(callbackQuery);
            }
        }
    }
}
