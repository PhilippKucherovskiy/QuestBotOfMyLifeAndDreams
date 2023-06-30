using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;
using QuestBotOfMyLifeAndDreams.Services;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace QuestBotOfMyLifeAndDreams.Controllers
{
    public class GameController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly GameDictionary _gameDictionary;
        private readonly InlineController _inlineController;

        public GameController(ITelegramBotClient telegramBotClient, GameDictionary gameDictionary, InlineController inlineController)
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

                // Handle the user's choice based on the callback data
                await HandleUserChoice(callbackQuery);
            }
        }

        private async Task HandleUserChoice(CallbackQuery callbackQuery)
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

                // Pass the callbackQuery to the InlineController for further handling
                await _inlineController.Handle(callbackQuery);
            }
        }
    }
}
