using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using QuestBotOfMyLifeAndDreams.Configuration;
using Telegram.Bot.Types;
using QuestBotOfMyLifeAndDreams.Services;

namespace QuestBotOfMyLifeAndDreams.Controllers
{
    public class InlineController
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

            if (gameContent != null)
            {
                await SendMessage(gameContent, callbackQuery.Message.Chat.Id);
            }
        }

        private async Task SendMessage(GameContent gameContent, long chatId)
        {
            // Отправить текстовое сообщение
            await _telegramClient.SendTextMessageAsync(
                chatId: chatId,
                text: gameContent.Text
            );

            // Если есть варианты ответа, отправить клавиатуру с вариантами
            if (gameContent.Options != null && gameContent.Options.Length > 0)
            {
                var replyMarkup = new InlineKeyboardMarkup(
                    gameContent.Options.Select(option =>
                        InlineKeyboardButton.WithCallbackData(option.Text, option.NextBlock)
                    )
                );

                await _telegramClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: "Choose an option:",
                    replyMarkup: replyMarkup
                );
            }
        }
    }
}
