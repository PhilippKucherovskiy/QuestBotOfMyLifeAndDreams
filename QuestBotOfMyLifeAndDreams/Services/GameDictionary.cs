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
                Text = "Текст 1",
                Options = new[]
                {
                    new Option { Text = "1А", NextBlock = "Block1A" },
                    new Option { Text = "1В", NextBlock = "Block1B" }
                }
            };
            AddGameContent("StartBlock", startGameContent);

            var block1AContent = new GameContent
            {
                Text = "Текст 1А",
                Options = new[]
                {
                    new Option { Text = "1Б", NextBlock = "Block1C" },
                    new Option { Text = "1В", NextBlock = "Block1D" }
                }
            };
            AddGameContent("Block1A", block1AContent);

            var block1BContent = new GameContent
            {
                Text = "Текст 1Б",
                Options = new[]
                {
                    new Option { Text = "1В", NextBlock = "Block1E" }
                }
            };
            AddGameContent("Block1B", block1BContent);

            var block1CContent = new GameContent
            {
                Text = "Текст 1С",
                Options = new[]
                {
                    new Option { Text = "1В", NextBlock = "Block1E" }
                }
            };
            AddGameContent("Block1C", block1CContent);

            var block1DContent = new GameContent
            {
                Text = "Текст 1D",
                Options = new[]
                {
                    new Option { Text = "14", NextBlock = "Block14" },
                    new Option { Text = "7", NextBlock = "Block7" }
                }
            };
            AddGameContent("Block1D", block1DContent);

            var block1EContent = new GameContent
            {
                Text = "Текст 1E",
                Options = new[]
                {
                    new Option { Text = "14", NextBlock = "Block14" },
                    new Option { Text = "7", NextBlock = "Block7" }
                }
            };
            AddGameContent("Block1E", block1EContent);

            var block14Content = new GameContent
            {
                Text = "Текст 14"
            };
            AddGameContent("Block14", block14Content);

            var block7Content = new GameContent
            {
                Text = "Текст 7"
            };
            AddGameContent("Block7", block7Content);
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
