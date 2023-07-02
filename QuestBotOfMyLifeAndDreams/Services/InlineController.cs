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
        private long _chatId;
        private int _previousMessageId;
        private int _previousImageMessageId = 0;


        public InlineController(ITelegramBotClient telegramBotClient, GameDictionary gameDictionary)
        {
            _telegramClient = telegramBotClient;
            _gameDictionary = gameDictionary;
        }

        public async Task Handle(CallbackQuery callbackQuery)
        {
            var blockId = callbackQuery.Data;
            var gameContent = _gameDictionary.GetGameContent(blockId);

            // Удаляем предыдущие кнопки, текcт
            await DeletePreviousContent();

            if (gameContent.Options != null && gameContent.Options.Length > 0)
            {
                var replyMarkup = new InlineKeyboardMarkup(
                    gameContent.Options.Select(option =>
                        InlineKeyboardButton.WithCallbackData(option.Text, option.NextBlock)
                    )
                );

                // Отправляем новое сообщение с текстом и кнопками
                var message = await _telegramClient.SendTextMessageAsync(
                    chatId: callbackQuery.Message.Chat.Id,
                    text: gameContent.Text,
                    replyMarkup: replyMarkup
                );

                _chatId = message.Chat.Id;
                _previousMessageId = message.MessageId;
            }
            
            if (_previousImageMessageId != 0)
            {
                await _telegramClient.DeleteMessageAsync(_chatId, _previousImageMessageId);
            }


            if (gameContent.ImageUrl != null)
            {
                var photo = Telegram.Bot.Types.InputFile.FromUri(gameContent.ImageUrl);
                var message = await _telegramClient.SendPhotoAsync(
                    chatId: _chatId,
                    photo: photo,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                );
                _previousImageMessageId = message.MessageId;
            }

        }

        private async Task DeletePreviousContent()
        {
            if (_previousMessageId != 0)
            {
                // Удаляем предыдущие кнопки
                await _telegramClient.EditMessageReplyMarkupAsync(_chatId, _previousMessageId, replyMarkup: null);

                // Удаляем предыдущий текст
                await _telegramClient.DeleteMessageAsync(_chatId, _previousMessageId);

                _previousMessageId = 0;
            }
        }

    }
}
    
