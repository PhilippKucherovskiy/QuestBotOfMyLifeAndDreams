using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using QuestBotOfMyLifeAndDreams.Configuration;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading;
using Telegram.Bots.Types;
using InputFile = Telegram.Bot.Types.InputFile;

namespace QuestBotOfMyLifeAndDreams.Controllers
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public TextMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Telegram.Bot.Types.Message message, CancellationToken ct)
        {
            switch (message.Text)
            {
                case "/start":
                    // сообщение
                    await _telegramClient.SendTextMessageAsync(
                        message.Chat.Id, 
                        $"Казаран — страна, на которой лежит заклятие злых колдунов, страна, которую без конца терзают орды кошмарных монстров.Король Казарана погиб в бою, сражаясь с безжалостными людоедами, а его сын и наследник принц Золотой Сокол лежит без сознания в замке Казаран, отравленный прислужником колдуна Дакмуна. Маррис, старый придворный чародей Казарана, хранит в тайне покушение на Золотого Сокола и его нынешнее состояние: он не хочет, чтобы в такие тяжелые времена народ узнал, что остался без правителя и защитника. Люди и так были крайне подавлены и напуганы: ведь армия людоедов была на расстоянии всего лишь одного дневного перехода от замка Казаран. Но у мудрого Марриса созрел хитрый план. В поисках подходящей кандидатуры, способной заменить Золотого Сокола, он открыл Врата Времени.",
                        cancellationToken: ct);
                    
                    await _telegramClient.SendTextMessageAsync(
                        message.Chat.Id,
                        $" Минуту назад ты лежал в постели и смотрел YouTube, а в следующее мгновение тебя закружил чудовищный вихрь и помчал сквозь пространство и время. Ты оказался в замке Казаран, став абсолютной копией принца Золотого Сокола. Согласившись помочь Маррису, ты отправился на поиски древней короны королей Казарана, попавшей в лапы к зловещему Дакмуну. В твоих приключениях тебе помогали два странных существа — Орландо, верный слуга принца, бывший Карлик, превращенный Дакмуном в Металлического Поросенка, и Эдж — говорящий меч. Полная опасностей дорога пролегала через лес Лонгшэдоу и Воющие Туннели и, наконец, привела тебя к мрачному обиталищу Дакмуна — замку Маггот. С помощью древней святыни Эльфов — браслета Золотой Руки — тебе удалось победить Дакмуна и заставить его превратить самого себя в белую мышь. Ты с триумфом вернулся в замок Казаран, где счастливые подданные во главе с Маррисом устроили тебе горячий прием, достойный настоящего героя.",
                        cancellationToken: ct);

                    await _telegramClient.SendTextMessageAsync(
                        message.Chat.Id,
                        $"Веря, что видят перед собой настоящего принца, граждане Казарана хотят чтобы ты стал их королем. В тиши своей библиотеки Маррис предлагает тебе корону, зная, что тебе придется покинуть твой собственный мир, и возможно навсегда. Ты ответил ему что дашь ответ утром...",
                        cancellationToken: ct);

                    await _telegramClient.SendPhotoAsync(
                       message.Chat.Id,
                        photo: InputFile.FromUri("https://files.fm/u/r6qg8nvqm"),
                        cancellationToken: ct);
                    break;
                default:
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, "Отправьте /start, чтобы Ваше приключение началось! ", cancellationToken: ct);
                    break;
            }
        }
    }
} 
