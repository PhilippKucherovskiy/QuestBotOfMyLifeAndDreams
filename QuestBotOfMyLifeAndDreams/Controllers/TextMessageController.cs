using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using QuestBotOfMyLifeAndDreams.Configuration;

namespace QuestBotOfMyLifeAndDreams.Controllers
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public TextMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            switch (message.Text)
            {
                case "/start":
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"<b>  Наш бот превращает аудио в текст.</b> {Environment.NewLine}", cancellationToken: ct);
            break;
                default:
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, "Отправьте '/start' для начала Вашего приключения!  ", cancellationToken: ct);
                    break;

            }
        }
    } }
