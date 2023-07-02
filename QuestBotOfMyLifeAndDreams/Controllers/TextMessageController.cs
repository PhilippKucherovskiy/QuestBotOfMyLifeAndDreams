using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using QuestBotOfMyLifeAndDreams.Services;
using System.Linq;
using Telegram.Bots.Types;
using InlineKeyboardMarkup = Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup;

namespace QuestBotOfMyLifeAndDreams.Controllers
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly GameDictionary _gameDictionary;
        private string _currentBlockId;

        public TextMessageController(ITelegramBotClient telegramBotClient, GameDictionary gameDictionary)
        {
            _telegramClient = telegramBotClient;
            _gameDictionary = gameDictionary;
            _currentBlockId = "StartBlock"; // Начальный блок игры
        }

        public async Task Handle(Telegram.Bot.Types.Message message)
        {
            if (message.Text == "/start")
            {
                _currentBlockId = "StartBlock"; // Устанавливаем начальный блок игры
                await StartGame(message.Chat.Id);
            }
            else
            {
                await ProcessGameContent(message.Chat.Id, message.Text);
            }
        }

        public async Task StartGame(long chatId)
        {
            var gameContent = _gameDictionary.GetGameContent(_currentBlockId);
            await SendGameContent(chatId, gameContent);
        }

        public async Task ProcessGameContent(long chatId, string userChoice)
        {
            var gameContent = _gameDictionary.GetGameContent(_currentBlockId);

            var selectedOption = gameContent.Options?.FirstOrDefault(option => option.Text == userChoice);
            if (selectedOption != null)
            {
                _currentBlockId = selectedOption.NextBlock;

                gameContent = _gameDictionary.GetGameContent(_currentBlockId);

                await SendGameContent(chatId, gameContent);
            }
            else
            {
                await _telegramClient.SendTextMessageAsync(chatId, "Invalid choice. Please try again.");
            }
        }

        public async Task SendGameContent(long chatId, GameContent gameContent)
        {
            await _telegramClient.SendTextMessageAsync(chatId, gameContent.Text);

            if (gameContent.Options != null && gameContent.Options.Length > 0)
            {
                var replyMarkup = new InlineKeyboardMarkup(
                    gameContent.Options.Select(option =>
                        InlineKeyboardButton.WithCallbackData(option.Text, option.NextBlock)
                    )
                );

                await _telegramClient.SendTextMessageAsync(chatId, "Choose an option:", replyMarkup: replyMarkup);
            }


            if (gameContent.ImageUrl != null)
            {
                var photo = Telegram.Bot.Types.InputFile.FromUri(gameContent.ImageUrl);

                await _telegramClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: photo,
                    parseMode: (Telegram.Bot.Types.Enums.ParseMode?)ParseMode.Html
                );
            }



        }
    }
}




