using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestBotOfMyLifeAndDreams.Services
{
    public class GameDictionary
    {
        private Dictionary<string, GameContent> _gameContentLookup;

        public GameDictionary()
        {
            // Initialize the game content lookup table
            _gameContentLookup = new Dictionary<string, GameContent>();

            // Add the game content for each block
            AddGameContent("Block1", new GameContent
            {
                Text = "This is the text for Block 1.",
                ImageUrl = "photoUrl1",
                Options = new[]
                {
                new Option { Text = "Option 1A", NextBlock = "Block2" },
                new Option { Text = "Option 1B", NextBlock = "Block3" }
            }
            });

            AddGameContent("Block2", new GameContent
            {
                Text = "This is the text for Block 2.",
                ImageUrl = "photoUrl2",
                Options = new[]
                {
                new Option { Text = "Option 2A", NextBlock = "Block4" },
                new Option { Text = "Option 2B", NextBlock = "Block5" }
            }
            });

            // Add more blocks of game content...
        }

        public GameContent GetGameContent(string blockId)
        {
            // Retrieve the game content based on the block ID
            if (_gameContentLookup.TryGetValue(blockId, out var gameContent))
            {
                return gameContent;
            }

            return null; // Block not found
        }

        private void AddGameContent(string blockId, GameContent gameContent)
        {
            _gameContentLookup[blockId] = gameContent;
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
