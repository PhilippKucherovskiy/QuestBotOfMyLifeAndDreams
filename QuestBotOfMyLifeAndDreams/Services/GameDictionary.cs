using System.Collections.Generic;

namespace QuestBotOfMyLifeAndDreams.Services
{
    public class GameDictionary
    {
        private readonly Dictionary<string, GameContent> _gameContentLookup;

        public GameDictionary()
        {
            _gameContentLookup = new Dictionary<string, GameContent>();

            // Добавьте начальное содержимое игры в конструкторе
            var startGameContent = new GameContent
            {
                Text = "Текст 1",
                Options = new[]
                {
                    new Option { Text = "1", NextBlock = "Block1A" },
                    new Option { Text = "2", NextBlock = "Block2A" }
                }
            };
            AddGameContent("StartBlock", startGameContent);

            // Добавьте другие блоки и их содержимое по необходимости
            var block1AContent = new GameContent
            {
                Text = "Текст 1А"
            };
            AddGameContent("Block1A", block1AContent);

            var block2AContent = new GameContent
            {
                Text = "Текст 2А"
            };
            AddGameContent("Block2A", block2AContent);
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
        public string ImageUrl { get; set; }
        public Option[] Options { get; set; }
    }

    public class Option
    {
        public string Text { get; set; }
        public string NextBlock { get; set; }
    }
}
