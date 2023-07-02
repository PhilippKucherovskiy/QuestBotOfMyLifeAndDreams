using System.Collections.Generic;
using System.IO;
using System.Net;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;
using Telegram.Bot.Types.InlineQueryResults;
using static System.Net.Mime.MediaTypeNames;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using File = System.IO.File;
using Microsoft.VisualBasic;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration;

namespace QuestBotOfMyLifeAndDreams.Services
{
    public class GameDictionary
    {
        private readonly Dictionary<string, GameContent> _gameContentLookup;

        public GameDictionary()
        {
            _gameContentLookup = new Dictionary<string, GameContent>();

            var startGameContent = new GameContent
            {
                Text = "Start Game",
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block01" }
                }
            };
            AddGameContent("StartBlock", startGameContent);


            var image01 = new Uri("https://files.fm/f/6pm2snysn");
            var block01Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\01.txt"),
                ImageUrl = image01,
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block02" }
                }
            };
            AddGameContent("Block01", block01Content);

            var block02Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\02.txt"),
                Options = new[]
               {
                    new Option { Text = "Дальше", NextBlock = "Block03" },

                }
            };
            AddGameContent("Block02", block02Content);

            var imageUrl03 = new Uri("https://files.fm/u/r6qg8nvqm");
            var block03Content = new GameContent
            {
                ImageUrl = imageUrl03,
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\03.txt"),
                Options = new[]
                {
        new Option { Text = "Дальше", NextBlock = "Block04" },
    }
            };
            AddGameContent("Block03", block03Content);

            
    
                var block04Content = new GameContent
            {
                    Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\04.txt"),
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block05" }
                }
            };
            AddGameContent("Block04", block04Content);

            var imageUrl05 = new Uri("https://files.fm/f/cjfz7dnfu");
            var block05Content = new GameContent
            {
                ImageUrl= imageUrl05,
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\05.txt"),
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block06" }
                }
            };
            AddGameContent("Block05", block05Content);

            var block06Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\06.txt"),
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block07" }
                }
            };
            AddGameContent("Block06", block06Content);

            var imageUrl07 = new Uri("https://files.fm/f/twxs9gzjk");
            var block07Content = new GameContent
            {
                ImageUrl = imageUrl07,
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\07.txt"),
                Options = new[]
                {
                    new Option { Text = "НАЧАТЬ ПРИКЛЮЧЕНИЕ", NextBlock = "Block1" },

                }
            };
            AddGameContent("Block07", block07Content);

            // Блок 1 
            var imageURL1 = new Uri("https://files.fm/f/w3sh2fyke");
            var block1Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\1.txt"),
                ImageUrl = imageURL1,
                Options = new[]
                {
                    new Option { Text = "Дать еды", NextBlock = "Block1A" },
                    new Option { Text = "Оставить Двухголового", NextBlock = "Block1C" }
                }
            };
            AddGameContent("Block1", block1Content);

            // Блок 1A
            var block1AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\1A.txt"),
                Options = new[]
                {
        new Option { Text = "Устраивает", NextBlock = "Block1B" },
        new Option { Text = "Оставить Двухголового", NextBlock = "Block1C" }
    }
            };
            AddGameContent("Block1A", block1AContent);

            // Блок 1B
            var block1BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\1B.txt"),
                Options = new[]
                {
        new Option { Text = "Оставить Двухголового", NextBlock = "Block1C" }
    }
            };
            AddGameContent("Block1B", block1BContent);

            // Блок 1C
            var imageUrl1C = new Uri("https://files.fm/f/8asmtq5hp");
            var block1CContent = new GameContent
            {   ImageUrl = imageUrl1C,
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\1C.txt"),
                Options = new[]
                {
        new Option { Text = "Пойти на Юг", NextBlock = "Block14" },
        new Option { Text = "Свернуть на Запад", NextBlock = "Block7" }
    }
            };
            AddGameContent("Block1C", block1CContent);

            // Блок 2
            var block2Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\2.txt"),
                Options = new[]
                {
        new Option { Text = "Поговорить", NextBlock = "Block2A" },
        new Option { Text = "Завязать Драку", NextBlock = "Block2B" },
        
    }
            };
            AddGameContent("Block2", block2Content);

            // Блок 2A
            var block2AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\2A.txt"),
                Options = new[]
                {
        new Option { Text = "Драться", NextBlock = "Block2B" },
        new Option { Text = "Дать кристалл", NextBlock = "Block2C" }
    }
            };
            AddGameContent("Block2A", block2AContent);

            // Блок 2B
            var block2BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\2B.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block2B" }
    }
            };
            AddGameContent("Block2B", block2BContent);

            // Блок 2C
            var block2CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\2C.txt"),
                Options = new[]
                {
        new Option { Text = "Направиться к хижине", NextBlock = "Block11" },
        new Option { Text = "Идти дальше", NextBlock = "Block18" }
    }
            };
            AddGameContent("Block2C", block2CContent);

            // Блок 3
            var block3Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\3.txt"),
                Options = new[]
                {
        new Option { Text = "Не знаю", NextBlock = "Block3A" },
        new Option { Text = "8", NextBlock = "Block8" }
    }
            };
            AddGameContent("Block3", block3Content);

            // Блок 3A
            var block3AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\3A.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block3A" }
    }
            };
            AddGameContent("Block3A", block3AContent);

            // Блок 4
            var block4Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\4.txt"),
                Options = new[]
                {
        new Option { Text = "Открыть мешок", NextBlock = "Block4A" },
        new Option { Text = "Войти в пещеру", NextBlock = "Block4B" },
        new Option { Text = "Продолжить путь", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4", block4Content);

            // Блок 4A
            var block4AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\4A.txt"),
                Options = new[]
                {
        new Option { Text = "Войти в пещеру", NextBlock = "Block4B" },
        new Option { Text = "Пойти дальше", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4A", block4AContent);

            // Блок 4B
            var block4BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\4B.txt"),
                Options = new[]
                {
        new Option { Text = "Разбить горшок", NextBlock = "Block4C" },
        new Option { Text = "Положить 1 золотую монету", NextBlock = "Block4D" },
        new Option { Text = "Выйти из пещеры", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4B", block4BContent);

            // Блок 4C
            var block4CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\4C.txt"),
                Options = new[]
                {
        new Option { Text = "Пойти дальше на Юг", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4C", block4CContent);

            // Блок 4D
            var block4DContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\4D.txt"),
                Options = new[]
                {
        new Option { Text = "Взять 1 кольцо", NextBlock = "Block6" },
        new Option { Text = "Взять оба кольца", NextBlock = "Block4E" },
    }
            };
            AddGameContent("Block4D", block4DContent);

            // Блок 4E
            var block4EContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\4E.txt"),

                Options = new[]
                {
                    new Option { Text = "NO CHOICE", NextBlock = "Block4E" },

            }
            };
            AddGameContent("Block4E", block4EContent);




            // Блок 5
            var block5Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\5.txt"),
                Options = new[]
                {
        new Option { Text = "Применить Ларец-Ловушку", NextBlock = "Block5A" },
        new Option { Text = "Сразиться мечом", NextBlock = "Block5B" }
    }
            };
            AddGameContent("Block5", block5Content);

            // Блок 5A
            var block5AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\5A.txt"),
                Options = new[]
                {
        new Option { Text = "Идти вглубь туннеля", NextBlock = "Block12" }
    }
            };
            AddGameContent("Block5A", block5AContent);

            // Блок 5B
            var block5BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\5A.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block5B" }
    }
            };
            AddGameContent("Block5B", block5BContent);

            // Блок 6
            var block6Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\6.txt"),
                Options = new[]
                {
        new Option { Text = "Зайти в палатку", NextBlock = "Block6A" },
        new Option { Text = "Напасть", NextBlock = "Block6B" },
        new Option { Text = "Попрощаться и пойти на Юг", NextBlock = "Block9" }
    }
            };
            AddGameContent("Block6", block6Content);

            // Блок 6A
            var block6AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\6A.txt"),
                Options = new[]
                {
        new Option { Text = "Не связываться с ковром-самолетом", NextBlock = "Block9" },
        new Option { Text = "Купить ковер-самолет", NextBlock = "Block6C" }
    }
            };
            AddGameContent("Block6A", block6AContent);

            // Блок 6B
            var block6BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\6B.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block6B" }
    }
            };
            AddGameContent("Block6B", block6BContent);

            // Блок 6C
            var block6CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\6C.txt"),
                Options = new[]
                {
        new Option { Text = "Взлететь на ковре-самолете", NextBlock = "Block17" }
    }
            };
            AddGameContent("Block6C", block6CContent);

            // Блок 7
            var block7Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\7.txt"),
                Options = new[]
                {
        new Option { Text = "Присутствовать на гонке", NextBlock = "Block7A" },
        new Option { Text = "Покинуть деревню", NextBlock = "Block7C" }
    }
            };
            AddGameContent("Block7", block7Content);

            // Блок 7A
            var block7AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\7A.txt"),
                Options = new[]
                {
        new Option { Text = "Купить книгу", NextBlock = "Block7B" },
        new Option { Text = "Покинуть деревню", NextBlock = "Block7C" }
    }
            };
            AddGameContent("Block7A", block7AContent);

            // Блок 7B
            var block7BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\7B.txt"),
                Options = new[]
                {
        new Option { Text = "Покинуть деревню", NextBlock = "Block7C" }
    }
            };
            AddGameContent("Block7B", block7BContent);

            // Блок 7C
            var block7CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\7C.txt"),
                Options = new[]
                {
        new Option { Text = "Пойти на Юг", NextBlock = "Block14" }
    }
            };
            AddGameContent("Block7C", block7CContent);

            // Блок 8
            var block8Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\8.txt"),
                Options = new[]
                {
        new Option { Text = "Подобрать хрустальный шар", NextBlock = "Block8A" },
        new Option { Text = "Выбежать из храма", NextBlock = "Block2" },
        new Option { Text = "Спуститься по лестнице", NextBlock = "Block15" }
    }
            };
            AddGameContent("Block8", block8Content);

            // Блок 8A
            var block8AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\8A.txt"),
                Options = new[]
                {
        new Option { Text = "8B", NextBlock = "Block8B" },
        new Option { Text = "8C", NextBlock = "Block8C" }
    }
            };
            AddGameContent("Block8A", block8AContent);

            // Блок 8B
            var block8BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\8B.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block8B" }
    }
            };
            AddGameContent("Block8B", block8BContent);

            // Блок 8C
            var block8CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\8C.txt"),
                Options = new[]
                {
        new Option { Text = "2", NextBlock = "Block2" },
        new Option { Text = "15", NextBlock = "Block15" }
    }
            };
            AddGameContent("Block8C", block8CContent);

            // Блок 9
            var block9Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\9.txt"),
                Options = new[]
                {
        new Option { Text = "9A", NextBlock = "Block9A" },
        new Option { Text = "9B", NextBlock = "Block9B" }
    }
            };
            AddGameContent("Block9", block9Content);

            // Блок 9A
            var block9AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\9A.txt"),
                Options = new[]
                {
        new Option { Text = "3", NextBlock = "Block3" }
    }
            };
            AddGameContent("Block9A", block9AContent);

            // Блок 9B
            var block9BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\9B.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block9B" }
    }
            };
            AddGameContent("Block9B", block9BContent);

            // Блок 10
            var block10Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\10.txt"),
                Options = new[]
                {
        new Option { Text = "10A", NextBlock = "Block10A" },
        new Option { Text = "10B", NextBlock = "Block10B" }
    }
            };
            AddGameContent("Block10", block10Content);

            // Блок 10A
            var block10AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\10A.txt"),
                Options = new[]
                {
        new Option { Text = "Заглянуть в боковой ход", NextBlock = "Block16" },
        new Option { Text = "Бежать по туннелю дальше", NextBlock = "Block5" }
    }
            };
            AddGameContent("Block10A", block10AContent);

            // Блок 10B
            var block10BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\10B.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block10A" }
    }
            };
            AddGameContent("Block10B", block10BContent);

            // Блок 11
            var block11Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\11.txt"),
                Options = new[]
                {
        new Option { Text = "Перенестись в Подземелье Отчаяния", NextBlock = "Block11A" },
        new Option { Text = "Получить Волшебную Палочку", NextBlock = "Block11B" }
    }
            };
            AddGameContent("Block11", block11Content);

            // Блок 11A
            var block11AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\11A.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block5" }
    }
            };
            AddGameContent("Block11A", block11AContent);

            // Блок 11B
            var block11BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\11B.txt"),
                Options = new[]
                {
        new Option { Text = "Продолжить путь", NextBlock = "Block18" }
    }
            };
            AddGameContent("Block11B", block11BContent);

            // Блок 12
            var block12Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\12.txt"),
                Options = new[]
                {
        new Option { Text = "12A", NextBlock = "Block12A" },
        new Option { Text = "12C", NextBlock = "Block12C" }
    }
            };
            AddGameContent("Block12", block12Content);

            // Блок 12A
            var block12AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\12A.txt"),
                Options = new[]
                {
        new Option { Text = "Взмахнуть Волшебной Палочкой", NextBlock = "Block12B" },
        new Option { Text = "12D", NextBlock = "Block12D" }
    }
            };
            AddGameContent("Block12A", block12AContent);

            // Блок 12B
            var block12BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\12B.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block13" }
    }
            };
            AddGameContent("Block12B", block12BContent);

            // Блок 12C
            var block12CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\12C.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block12C" }
    }
            };
            AddGameContent("Block12C", block12CContent);

            // Блок 12D
            var block12DContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\12D.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block12C" }
    }
            };
            AddGameContent("Block12D", block12DContent);

            // Блок 13
            var block13Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\13.txt"),
                Options = new[]
                {
        new Option { Text = "Сыграть на Магической Флейте", NextBlock = "Block13A" },
        new Option { Text = "13B", NextBlock = "Block13B" }
    }
            };
            AddGameContent("Block13", block13Content);

            // Блок 13A
            var block13AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\13A.txt"),
                Options = new[]
                {
        new Option { Text = "За Казаран!", NextBlock = "Block20" }
    }
            };
            AddGameContent("Block13A", block13AContent);

            // Блок 13B
            var block13BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\13B.txt"),
                Options = new[]
                {
        new Option { Text = "За Казаран!", NextBlock = "Block13B" }
    }
            };
            AddGameContent("Block13B", block13BContent);

            // Блок 14
            var imageUrl14 = new Uri("https://files.fm/f/gbqzmyyme");
            var block14Content = new GameContent
            {
                ImageUrl = imageUrl14,
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\14.txt"),
                Options = new[]
                {
        new Option { Text = "14A", NextBlock = "Block14A" },
        new Option { Text = "14B", NextBlock = "Block14B" }
    }
            };
            AddGameContent("Block14", block14Content);

            // Блок 14A
            
            var block14AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\14A.txt"),
                Options = new[]
                {
        new Option { Text = "14C", NextBlock = "Block14C" }
    }
            };
            AddGameContent("Block14A", block14AContent);

            // Блок 14B
            var block14BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\14B.txt"),
                Options = new[]
                {
        new Option { Text = "14A", NextBlock = "Block14A" }
    }
            };
            AddGameContent("Block14B", block14BContent);

            // Блок 14C
            var block14CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\14C.txt"),
                Options = new[]
                {
        new Option { Text = "Пойти по следам", NextBlock = "Block19" },
        new Option { Text = "Продолжить путь на Юг", NextBlock = "Block4" }
    }
            };
            AddGameContent("Block14C", block14CContent);

            // Блок 15
            var block15Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\15.txt"),
                Options = new[]
                {
        new Option { Text = "Отдать скрипичную струну", NextBlock = "Block15A" },
        new Option { Text = "15B", NextBlock = "Block15B" }
    }
            };
            AddGameContent("Block15", block15Content);

            // Блок 15A
            var block15AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\15A.txt"),
                Options = new[]
                {
        new Option { Text = "Продолжить путь по Долине", NextBlock = "Block2" }
    }
            };
            AddGameContent("Block15A", block15AContent);

            // Блок 15B
            var block15BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\15B.txt"),
                Options = new[]
                {
        new Option { Text = "Продолжить путь по Долине", NextBlock = "Block2" }
    }
            };
            AddGameContent("Block15B", block15BContent);

            // Блок 16
            var block16Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\16.txt"),
                Options = new[]
                {
        new Option { Text = "16A", NextBlock = "Block16A" },
        new Option { Text = "Продолжить путь", NextBlock = "Block5" }
    }
            };
            AddGameContent("Block16", block16Content);

            // Блок 16A
            var block16AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\16A.txt"),
                Options = new[]
                {
        new Option { Text = "Продолжить путь", NextBlock = "Block5" }
    }
            };
            AddGameContent("Block16A", block16AContent);

            // Блок 17
            var block17Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\17.txt"),
                Options = new[]
                {
        new Option { Text = "Идерепв", NextBlock = "Block17A" },
        new Option { Text = "Дерепв", NextBlock = "Block17B" }
    }
            };
            AddGameContent("Block17", block17Content);

            // Блок 17A
            var block17AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\17A.txt"),
                Options = new[]
                {
        new Option { Text = "Дальше", NextBlock = "Block9" }
    }
            };
            AddGameContent("Block17A", block17AContent);

            // Блок 17B
            var block17BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\17B.txt"),
                Options = new[]
                {
        new Option { Text = "В дорогу", NextBlock = "Block3" }
    }
            };
            AddGameContent("Block17B", block17BContent);

            // Блок 18
            var block18Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\18.txt"),
                Options = new[]
                {
        new Option { Text = "Синий цвет", NextBlock = "Block18A" },
        new Option { Text = "Красный цвет", NextBlock = "Block18B" }
    }
            };
            AddGameContent("Block18", block18Content);

            // Блок 18A
            var block18AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\18A.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block18C" }
    }
            };
            AddGameContent("Block18A", block18AContent);

            // Блок 18B
            var block18BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\18B.txt"),
                Options = new[]
                {
        new Option { Text = "Дальше", NextBlock = "Block18D" }
    }
            };
            AddGameContent("Block18B", block18BContent);

            // Блок 18C
            var block18CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\18C.txt"),
                Options = new[]
                {
        new Option { Text = "10", NextBlock = "Block10" },
        new Option { Text = "Не могу сосчитать", NextBlock = "Block18D" }
    }
            };
            AddGameContent("Block18C", block18CContent);

            // Блок 18D
            var block18DContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\18D.txt"),
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block18D" }
    }
            };
            AddGameContent("Block18D", block18DContent);

            // Блок 19
            var block19Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\19.txt"),
                Options = new[]
                {
        new Option { Text = "Сразиться", NextBlock = "Block19A" },
        new Option { Text = "Идти дальше на Юг", NextBlock = "Block6" },
        new Option { Text = "Вернуться на дорогу", NextBlock = "Block4" }
    }
            };
            AddGameContent("Block19", block19Content);

            // Блок 19A
            var block19AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\19A.txt"),
                Options = new[]
                {
        new Option { Text = "Использовать меч", NextBlock = "Block19B" },
        new Option { Text = "Придумать уловку", NextBlock = "Block19C" }
    }
            };
            AddGameContent("Block19A", block19AContent);

            // Блок 19B
            var block19BContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\19B.txt"),
                Options = new[]
                {
        new Option { Text = "Придумать уловку", NextBlock = "Block19C" }
    }
            };
            AddGameContent("Block19B", block19BContent);

            // Блок 19C
            var block19CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\19C.txt"),
                Options = new[]
                {
        new Option { Text = "Прямо на Юг", NextBlock = "Block6" },
        new Option { Text = "Сначала на прежнюю дорогу", NextBlock = "Block4" }
    }
            };
            AddGameContent("Block19C", block19CContent);

            // Блок 20
            var block20Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\20.txt"),
                Options = new[]
                {
        new Option { Text = "Использовать Кроличью Лапку", NextBlock = "Block20A" },
        new Option { Text = "Далее", NextBlock = "Block20B" }
    }
            };
            AddGameContent("Block20", block20Content);

            // Блок 20A
            var block20AContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\20A.txt"),
                Options = new[]
                {
        new Option { Text = "20C", NextBlock = "Block20C" }
    }
            };
            AddGameContent("Block20A", block20AContent);

            // Блок 20C
            var block20CContent = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\20C.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block21" }
    }
            };
            AddGameContent("Block20C", block20CContent);

            // Блок 21
            var block21Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\21.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block22" }
    }
            };
            AddGameContent("Block21", block21Content);

            // Блок 22
            var block22Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\22.txt"),
                Options = new[]
                {
        new Option { Text = "Далее", NextBlock = "Block23" }
    }
            };
            AddGameContent("Block22", block22Content);

            // Блок 23
            var block23Content = new GameContent
            {
                Text = File.ReadAllText(@"C:\Users\Admin\source\repos\QuestBotOfMyLifeAndDreams\Тексты\23.txt"),
                Options = new[]
                {
                 new Option { Text = "NO CHOICE", NextBlock = "Block23" }
    }
            };
            AddGameContent("Block23", block23Content);


        }

        public void AddGameContent(string blockId, GameContent gameContent)
        {
            _gameContentLookup[blockId] = gameContent;
        }

        public GameContent GetGameContent(string blockId)
        {
            if (_gameContentLookup.TryGetValue(blockId, out var gameContent))
            {
                return gameContent;
            }

            return null;
        }
    }

    public class GameContent
    {
        public string Text { get; set; }
        public Option[] Options { get; set; }
        public Uri ImageUrl { get; set; }

        
    }


    public class Option
    {
        public string Text { get; set; }
        public string NextBlock { get; set; }
    }
    
    
}
