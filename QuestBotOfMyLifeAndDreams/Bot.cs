using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Polling;
using QuestBotOfMyLifeAndDreams.Controllers;
using QuestBotOfMyLifeAndDreams.Services;

namespace QuestBotOfMyLifeAndDreams
{
    internal class Bot : BackgroundService
    {
        private ITelegramBotClient _telegramClient;

        // Контроллеры различных видов сообщений
        private InlineController _inlineController;
        private TextMessageController _textMessageController;
        private DefaultMessageController _defaultMessageController;

        private GameDictionary _gameDictionary;

        public Bot(
            ITelegramBotClient telegramClient,
            InlineController inlineController,
            TextMessageController textMessageController,
            DefaultMessageController defaultMessageController,
            GameDictionary gameDictionary)
        {
            _telegramClient = telegramClient;
            _inlineController = inlineController;
            _textMessageController = textMessageController;
            _defaultMessageController = defaultMessageController;
            _gameDictionary = gameDictionary;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _telegramClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                new ReceiverOptions() { AllowedUpdates = { } }, // Здесь выбираем, какие обновления хотим получать. В данном случае разрешены все
                cancellationToken: stoppingToken);

            Console.WriteLine("Бот запущен");
        }

        async Task HandleUpdateAsync(ITelegramBotClient telegramClient, Update update, CancellationToken cancellationToken)
        {
            // Handle callback queries
            if (update.Type == UpdateType.CallbackQuery)
            {
                await _inlineController.Handle(update.CallbackQuery);
            }
            else if (update.Type == UpdateType.Message)
            {
                var message = update.Message;

                // Handle text messages
                if (message.Type == MessageType.Text)
                {
                    await _textMessageController.Handle(message);
                }
                else
                {
                    // Handle other types of messages
                    await _defaultMessageController.Handle(message, cancellationToken);
                }
            }
        }

        Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Задаем сообщение об ошибке в зависимости от того, какая именно ошибка произошла
            var errorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            // Выводим в консоль информацию об ошибке
            Console.WriteLine(errorMessage);

            // Задержка перед повторным подключением
            Console.WriteLine("Ожидаем 10 секунд перед повторным подключением.");
            Thread.Sleep(10000);

            return Task.CompletedTask;
        }
    }
}
