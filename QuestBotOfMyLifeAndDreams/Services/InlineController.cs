using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using QuestBotOfMyLifeAndDreams.Configuration;
using QuestBotOfMyLifeAndDreams.Controllers;
using Telegram.Bot.Types.Enums;


namespace QuestBotOfMyLifeAndDreams.Services
{
    public class InlineController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly GameController _gameController;

        public InlineController(ITelegramBotClient telegramBotClient, GameController gameController)
        {
            _telegramClient = telegramBotClient;
            _gameController = gameController;
        }

        public async Task Handle(CallbackQuery callbackQuery)
        {
            var update = new Update
            {
                CallbackQuery = callbackQuery
            };

        }

    }

}
