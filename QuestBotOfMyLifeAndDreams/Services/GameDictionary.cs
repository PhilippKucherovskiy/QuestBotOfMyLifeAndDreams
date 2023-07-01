using System.Collections.Generic;

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



            var block01Content = new GameContent
            {
                Text = "01",
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block03" },

                }
            };
            AddGameContent("Block01", block01Content);

            var block03Content = new GameContent
            {
                Text = "03",
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block04" },

                }
            };
            AddGameContent("Block03", block03Content);

            var block04Content = new GameContent
            {
                Text = "04",
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block05" }
                }
            };
            AddGameContent("Block04", block04Content);

            var block05Content = new GameContent
            {
                Text = "05",
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block06" }
                }
            };
            AddGameContent("Block05", block05Content);

            var block06Content = new GameContent
            {
                Text = "06",
                Options = new[]
                {
                    new Option { Text = "Дальше", NextBlock = "Block07" }
                }
            };
            AddGameContent("Block06", block06Content);

            var block07Content = new GameContent
            {
                Text = "07",
                Options = new[]
                {
                    new Option { Text = "НАЧАТЬ ПРИКЛЮЧЕНИЕ", NextBlock = "Block1" },

                }
            };
            AddGameContent("Block07", block07Content);

            // Блок 1 
            var block1Content = new GameContent
            {
                Text = "Блок 1",
                Options = new[]
                {
                    new Option { Text = "1A", NextBlock = "Block1A" },
                    new Option { Text = "1C", NextBlock = "Block1C" }
                }
            };
            AddGameContent("Block1", block1Content);

            // Блок 1A
            var block1AContent = new GameContent
            {
                Text = "Блок 1A",
                Options = new[]
                {
        new Option { Text = "1B", NextBlock = "Block1B" },
        new Option { Text = "1C", NextBlock = "Block1C" }
    }
            };
            AddGameContent("Block1A", block1AContent);

            // Блок 1B
            var block1BContent = new GameContent
            {
                Text = "Блок 1B",
                Options = new[]
                {
        new Option { Text = "1C", NextBlock = "Block1C" }
    }
            };
            AddGameContent("Block1B", block1BContent);

            // Блок 1C
            var block1CContent = new GameContent
            {
                Text = "Блок 1C",
                Options = new[]
                {
        new Option { Text = "14", NextBlock = "Block14" },
        new Option { Text = "7", NextBlock = "Block7" }
    }
            };
            AddGameContent("Block1C", block1CContent);

            // Блок 2
            var block2Content = new GameContent
            {
                Text = "Блок 2",
                Options = new[]
                {
        new Option { Text = "2A", NextBlock = "Block2A" },
        new Option { Text = "2B", NextBlock = "Block2B" },
        new Option { Text = "2C", NextBlock = "Block2C" }
    }
            };
            AddGameContent("Block2", block2Content);

            // Блок 2A
            var block2AContent = new GameContent
            {
                Text = "Блок 2A",
                Options = new[]
                {
        new Option { Text = "2B", NextBlock = "Block2B" },
        new Option { Text = "2C", NextBlock = "Block2C" }
    }
            };
            AddGameContent("Block2A", block2AContent);

            // Блок 2B
            var block2BContent = new GameContent
            {
                Text = "Блок 2B",
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block2B" }
    }
            };
            AddGameContent("Block2B", block2BContent);

            // Блок 2C
            var block2CContent = new GameContent
            {
                Text = "Блок 2C",
                Options = new[]
                {
        new Option { Text = "11", NextBlock = "Block11" },
        new Option { Text = "18", NextBlock = "Block18" }
    }
            };
            AddGameContent("Block2C", block2CContent);

            // Блок 3
            var block3Content = new GameContent
            {
                Text = "Блок 3",
                Options = new[]
                {
        new Option { Text = "3A", NextBlock = "Block3A" },
        new Option { Text = "8", NextBlock = "Block8" }
    }
            };
            AddGameContent("Block3", block3Content);

            // Блок 3A
            var block3AContent = new GameContent
            {
                Text = "Блок 3A",
                Options = new[]
                {
        new Option { Text = "9", NextBlock = "Block9" }
    }
            };
            AddGameContent("Block3A", block3AContent);

            // Блок 4
            var block4Content = new GameContent
            {
                Text = "Блок 4",
                Options = new[]
                {
        new Option { Text = "4A", NextBlock = "Block4A" },
        new Option { Text = "4B", NextBlock = "Block4B" },
        new Option { Text = "6", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4", block4Content);

            // Блок 4A
            var block4AContent = new GameContent
            {
                Text = "Блок 4A",
                Options = new[]
                {
        new Option { Text = "4B", NextBlock = "Block4B" },
        new Option { Text = "6", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4A", block4AContent);

            // Блок 4B
            var block4BContent = new GameContent
            {
                Text = "Блок 4B",
                Options = new[]
                {
        new Option { Text = "4C", NextBlock = "Block4C" },
        new Option { Text = "4D", NextBlock = "Block4D" },
        new Option { Text = "6", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4B", block4BContent);

            // Блок 4C
            var block4CContent = new GameContent
            {
                Text = "Блок 4C",
                Options = new[]
                {
        new Option { Text = "6", NextBlock = "Block6" }
    }
            };
            AddGameContent("Block4C", block4CContent);

            // Блок 4D
            var block4DContent = new GameContent
            {
                Text = "Блок 4D",
                Options = new[]
                {
        new Option { Text = "6", NextBlock = "Block6" },
        new Option { Text = "4E", NextBlock = "Block4E" },
        new Option { Text = "NO CHOICE", NextBlock = "Block4D" }
    }
            };
            AddGameContent("Block4D", block4DContent);

            // Блок 5
            var block5Content = new GameContent
            {
                Text = "Блок 5",
                Options = new[]
                {
        new Option { Text = "5A", NextBlock = "Block5A" },
        new Option { Text = "5B", NextBlock = "Block5B" }
    }
            };
            AddGameContent("Block5", block5Content);

            // Блок 5A
            var block5AContent = new GameContent
            {
                Text = "Блок 5A",
                Options = new[]
                {
        new Option { Text = "12", NextBlock = "Block12" },
        new Option { Text = "NO CHOICE", NextBlock = "Block5A" }
    }
            };
            AddGameContent("Block5A", block5AContent);

            // Блок 6
            var block6Content = new GameContent
            {
                Text = "Блок 6",
                Options = new[]
                {
        new Option { Text = "6A", NextBlock = "Block6A" },
        new Option { Text = "6B", NextBlock = "Block6B" },
        new Option { Text = "9", NextBlock = "Block9" }
    }
            };
            AddGameContent("Block6", block6Content);

            // Блок 6A
            var block6AContent = new GameContent
            {
                Text = "Блок 6A",
                Options = new[]
                {
        new Option { Text = "9", NextBlock = "Block9" },
        new Option { Text = "6C", NextBlock = "Block6C" }
    }
            };
            AddGameContent("Block6A", block6AContent);

            // Блок 6B
            var block6BContent = new GameContent
            {
                Text = "Блок 6B",
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block6B" }
    }
            };
            AddGameContent("Block6B", block6BContent);

            // Блок 6C
            var block6CContent = new GameContent
            {
                Text = "Блок 6C",
                Options = new[]
                {
        new Option { Text = "17", NextBlock = "Block17" }
    }
            };
            AddGameContent("Block6C", block6CContent);

            // Блок 7
            var block7Content = new GameContent
            {
                Text = "Блок 7",
                Options = new[]
                {
        new Option { Text = "7A", NextBlock = "Block7A" },
        new Option { Text = "7C", NextBlock = "Block7C" }
    }
            };
            AddGameContent("Block7", block7Content);

            // Блок 7A
            var block7AContent = new GameContent
            {
                Text = "Блок 7A",
                Options = new[]
                {
        new Option { Text = "7B", NextBlock = "Block7B" },
        new Option { Text = "7C", NextBlock = "Block7C" }
    }
            };
            AddGameContent("Block7A", block7AContent);

            // Блок 7B
            var block7BContent = new GameContent
            {
                Text = "Блок 7B",
                Options = new[]
                {
        new Option { Text = "7C", NextBlock = "Block7C" }
    }
            };
            AddGameContent("Block7B", block7BContent);

            // Блок 7C
            var block7CContent = new GameContent
            {
                Text = "Блок 7C",
                Options = new[]
                {
        new Option { Text = "14", NextBlock = "Block14" }
    }
            };
            AddGameContent("Block7C", block7CContent);

            // Блок 8
            var block8Content = new GameContent
            {
                Text = "Блок 8",
                Options = new[]
                {
        new Option { Text = "8A", NextBlock = "Block8A" },
        new Option { Text = "2", NextBlock = "Block2" },
        new Option { Text = "15", NextBlock = "Block15" }
    }
            };
            AddGameContent("Block8", block8Content);

            // Блок 8A
            var block8AContent = new GameContent
            {
                Text = "Блок 8A",
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
                Text = "Блок 8B",
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block8B" }
    }
            };
            AddGameContent("Block8B", block8BContent);

            // Блок 8C
            var block8CContent = new GameContent
            {
                Text = "Блок 8C",
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
                Text = "Блок 9",
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
                Text = "Блок 9A",
                Options = new[]
                {
        new Option { Text = "3", NextBlock = "Block3" }
    }
            };
            AddGameContent("Block9A", block9AContent);

            // Блок 9B
            var block9BContent = new GameContent
            {
                Text = "Блок 9B",
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block9B" }
    }
            };
            AddGameContent("Block9B", block9BContent);

            // Блок 10
            var block10Content = new GameContent
            {
                Text = "Блок 10",
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
                Text = "Блок 10A",
                Options = new[]
                {
        new Option { Text = "16", NextBlock = "Block16" },
        new Option { Text = "5", NextBlock = "Block5" }
    }
            };
            AddGameContent("Block10A", block10AContent);

            // Блок 10B
            var block10BContent = new GameContent
            {
                Text = "Блок 10B",
                Options = new[]
                {
        new Option { Text = "10A", NextBlock = "Block10A" }
    }
            };
            AddGameContent("Block10B", block10BContent);

            // Блок 11
            var block11Content = new GameContent
            {
                Text = "Блок 11",
                Options = new[]
                {
        new Option { Text = "11A", NextBlock = "Block11A" },
        new Option { Text = "11B", NextBlock = "Block11B" }
    }
            };
            AddGameContent("Block11", block11Content);

            // Блок 11A
            var block11AContent = new GameContent
            {
                Text = "Блок 11A",
                Options = new[]
                {
        new Option { Text = "5", NextBlock = "Block5" }
    }
            };
            AddGameContent("Block11A", block11AContent);

            // Блок 11B
            var block11BContent = new GameContent
            {
                Text = "Блок 11B",
                Options = new[]
                {
        new Option { Text = "18", NextBlock = "Block18" }
    }
            };
            AddGameContent("Block11B", block11BContent);

            // Блок 12
            var block12Content = new GameContent
            {
                Text = "Блок 12",
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
                Text = "Блок 12A",
                Options = new[]
                {
        new Option { Text = "12B", NextBlock = "Block12B" },
        new Option { Text = "12D", NextBlock = "Block12D" }
    }
            };
            AddGameContent("Block12A", block12AContent);

            // Блок 12B
            var block12BContent = new GameContent
            {
                Text = "Блок 12B",
                Options = new[]
                {
        new Option { Text = "13", NextBlock = "Block13" }
    }
            };
            AddGameContent("Block12B", block12BContent);

            // Блок 12D
            var block12DContent = new GameContent
            {
                Text = "Блок 12D",
                Options = new[]
                {
        new Option { Text = "12C", NextBlock = "Block12C" }
    }
            };
            AddGameContent("Block12D", block12DContent);

            // Блок 13
            var block13Content = new GameContent
            {
                Text = "Блок 13",
                Options = new[]
                {
        new Option { Text = "13A", NextBlock = "Block13A" },
        new Option { Text = "13B", NextBlock = "Block13B" }
    }
            };
            AddGameContent("Block13", block13Content);

            // Блок 13A
            var block13AContent = new GameContent
            {
                Text = "Блок 13A",
                Options = new[]
                {
        new Option { Text = "20", NextBlock = "Block20" }
    }
            };
            AddGameContent("Block13A", block13AContent);

            // Блок 14
            var block14Content = new GameContent
            {
                Text = "Блок 14",
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
                Text = "Блок 14A",
                Options = new[]
                {
        new Option { Text = "14C", NextBlock = "Block14C" }
    }
            };
            AddGameContent("Block14A", block14AContent);

            // Блок 14B
            var block14BContent = new GameContent
            {
                Text = "Блок 14B",
                Options = new[]
                {
        new Option { Text = "14A", NextBlock = "Block14A" }
    }
            };
            AddGameContent("Block14B", block14BContent);

            // Блок 14C
            var block14CContent = new GameContent
            {
                Text = "Блок 14C",
                Options = new[]
                {
        new Option { Text = "19", NextBlock = "Block19" },
        new Option { Text = "4", NextBlock = "Block4" }
    }
            };
            AddGameContent("Block14C", block14CContent);

            // Блок 15
            var block15Content = new GameContent
            {
                Text = "Блок 15",
                Options = new[]
                {
        new Option { Text = "15A", NextBlock = "Block15A" },
        new Option { Text = "15B", NextBlock = "Block15B" }
    }
            };
            AddGameContent("Block15", block15Content);

            // Блок 15A
            var block15AContent = new GameContent
            {
                Text = "Блок 15A",
                Options = new[]
                {
        new Option { Text = "2", NextBlock = "Block2" }
    }
            };
            AddGameContent("Block15A", block15AContent);

            // Блок 15B
            var block15BContent = new GameContent
            {
                Text = "Блок 15B",
                Options = new[]
                {
        new Option { Text = "2", NextBlock = "Block2" }
    }
            };
            AddGameContent("Block15B", block15BContent);

            // Блок 16
            var block16Content = new GameContent
            {
                Text = "Блок 16",
                Options = new[]
                {
        new Option { Text = "16A", NextBlock = "Block16A" }
    }
            };
            AddGameContent("Block16", block16Content);

            // Блок 16A
            var block16AContent = new GameContent
            {
                Text = "Блок 16A",
                Options = new[]
                {
        new Option { Text = "5", NextBlock = "Block5" }
    }
            };
            AddGameContent("Block16A", block16AContent);

            // Блок 17
            var block17Content = new GameContent
            {
                Text = "Блок 17",
                Options = new[]
                {
        new Option { Text = "17A", NextBlock = "Block17A" },
        new Option { Text = "17B", NextBlock = "Block17B" }
    }
            };
            AddGameContent("Block17", block17Content);

            // Блок 17A
            var block17AContent = new GameContent
            {
                Text = "Блок 17A",
                Options = new[]
                {
        new Option { Text = "9", NextBlock = "Block9" }
    }
            };
            AddGameContent("Block17A", block17AContent);

            // Блок 17B
            var block17BContent = new GameContent
            {
                Text = "Блок 17B",
                Options = new[]
                {
        new Option { Text = "3", NextBlock = "Block3" }
    }
            };
            AddGameContent("Block17B", block17BContent);

            // Блок 18
            var block18Content = new GameContent
            {
                Text = "Блок 18",
                Options = new[]
                {
        new Option { Text = "18A", NextBlock = "Block18A" },
        new Option { Text = "18B", NextBlock = "Block18B" }
    }
            };
            AddGameContent("Block18", block18Content);

            // Блок 18A
            var block18AContent = new GameContent
            {
                Text = "Блок 18A",
                Options = new[]
                {
        new Option { Text = "18C", NextBlock = "Block18C" }
    }
            };
            AddGameContent("Block18A", block18AContent);

            // Блок 18B
            var block18BContent = new GameContent
            {
                Text = "Блок 18B",
                Options = new[]
                {
        new Option { Text = "18D", NextBlock = "Block18D" }
    }
            };
            AddGameContent("Block18B", block18BContent);

            // Блок 18C
            var block18CContent = new GameContent
            {
                Text = "Блок 18C",
                Options = new[]
                {
        new Option { Text = "10", NextBlock = "Block10" },
        new Option { Text = "18D", NextBlock = "Block18D" }
    }
            };
            AddGameContent("Block18C", block18CContent);

            // Блок 18D
            var block18DContent = new GameContent
            {
                Text = "Блок 18D",
                Options = new[]
                {
        new Option { Text = "NO CHOICE", NextBlock = "Block18D" }
    }
            };
            AddGameContent("Block18D", block18DContent);

            // Блок 19
            var block19Content = new GameContent
            {
                Text = "Блок 19",
                Options = new[]
                {
        new Option { Text = "19A", NextBlock = "Block19A" },
        new Option { Text = "6", NextBlock = "Block6" },
        new Option { Text = "4", NextBlock = "Block4" }
    }
            };
            AddGameContent("Block19", block19Content);

            // Блок 19A
            var block19AContent = new GameContent
            {
                Text = "Блок 19A",
                Options = new[]
                {
        new Option { Text = "19B", NextBlock = "Block19B" },
        new Option { Text = "19C", NextBlock = "Block19C" }
    }
            };
            AddGameContent("Block19A", block19AContent);

            // Блок 19B
            var block19BContent = new GameContent
            {
                Text = "Блок 19B",
                Options = new[]
                {
        new Option { Text = "19C", NextBlock = "Block19C" }
    }
            };
            AddGameContent("Block19B", block19BContent);

            // Блок 19C
            var block19CContent = new GameContent
            {
                Text = "Блок 19C",
                Options = new[]
                {
        new Option { Text = "6", NextBlock = "Block6" },
        new Option { Text = "4", NextBlock = "Block4" }
    }
            };
            AddGameContent("Block19C", block19CContent);

            // Блок 20
            var block20Content = new GameContent
            {
                Text = "Блок 20",
                Options = new[]
                {
        new Option { Text = "20A", NextBlock = "Block20A" },
        new Option { Text = "20B", NextBlock = "Block20B" }
    }
            };
            AddGameContent("Block20", block20Content);

            // Блок 20A
            var block20AContent = new GameContent
            {
                Text = "Блок 20A",
                Options = new[]
                {
        new Option { Text = "20C", NextBlock = "Block20C" }
    }
            };
            AddGameContent("Block20A", block20AContent);

            // Блок 20C
            var block20CContent = new GameContent
            {
                Text = "Блок 20C",
                Options = new[]
                {
        new Option { Text = "21", NextBlock = "Block21" }
    }
            };
            AddGameContent("Block20C", block20CContent);

            // Блок 21
            var block21Content = new GameContent
            {
                Text = "Блок 21",
                Options = new[]
                {
        new Option { Text = "22", NextBlock = "Block22" }
    }
            };
            AddGameContent("Block21", block21Content);

            // Блок 22
            var block22Content = new GameContent
            {
                Text = "Блок 22",
                Options = new[]
                {
        new Option { Text = "23", NextBlock = "Block23" }
    }
            };
            AddGameContent("Block22", block22Content);

            // Блок 23
            var block23Content = new GameContent
            {
                Text = "Блок 23",
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
    }

    public class Option
    {
        public string Text { get; set; }
        public string NextBlock { get; set; }
    }
}
