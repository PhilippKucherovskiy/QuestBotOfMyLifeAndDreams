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

                // Удаляем предыдущие кнопки, если они были
                await DeletePreviousButtons();

                if (_previousMessageId == 0)
                {
                    // Отправляем новое сообщение с текстом и кнопками
                    var message = await _telegramClient.SendTextMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        text: gameContent.Text,
                        replyMarkup: replyMarkup
                    );

                    _chatId = message.Chat.Id;
                    _previousMessageId = message.MessageId;
                }
                else
                {
                    // Редактируем предыдущее сообщение, заменяя кнопки
                    await _telegramClient.EditMessageTextAsync(
                        chatId: _chatId,
                        messageId: _previousMessageId,
                        text: gameContent.Text,
                        replyMarkup: replyMarkup
                    );
                }
            }
            else
            {
                // Удаляем предыдущие кнопки, если они были
                await DeletePreviousButtons();

                // Отправляем новое сообщение только с текстом
                var message = await _telegramClient.SendTextMessageAsync(
                    chatId: callbackQuery.Message.Chat.Id,
                    text: gameContent.Text
                );

                _chatId = message.Chat.Id;
                _previousMessageId = message.MessageId;
            }
        }

        private async Task DeletePreviousButtons()
        {
            if (_previousMessageId != 0)
            {
                // Удаляем предыдущие кнопки
                await _telegramClient.EditMessageReplyMarkupAsync(_chatId, _previousMessageId, replyMarkup: null);

                // Удаляем первые кнопки
                await _telegramClient.DeleteMessageAsync(_chatId, _previousMessageId - 1);

                _previousMessageId = 0;
            }
        }
    }
}
