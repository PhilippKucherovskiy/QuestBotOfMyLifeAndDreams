using QuestBotOfMyLifeAndDreams.Controllers;
using Telegram.Bot;
using Telegram.Bot.Types;

public class TextMessageController
{
    private readonly ITelegramBotClient _telegramClient;
    private readonly GameController _gameController;

    public TextMessageController(ITelegramBotClient telegramBotClient, GameController gameController)
    {
        _telegramClient = telegramBotClient;
        _gameController = gameController;
    }

    public async Task Handle(Message message, Update update)
    {
        // Передаем обновление в GameController для обработки глав
        await _gameController.Handle(update);
    }

}
