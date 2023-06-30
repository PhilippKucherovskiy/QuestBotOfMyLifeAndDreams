using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace QuestBotOfMyLifeAndDreams.Services
{
    public interface IInlineController
    {
        Task Handle(CallbackQuery callbackQuery);
    }
}
