using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestBotOfMyLifeAndDreams
{
    public class TextBlockGraph
    {
        private Dictionary<string, TextBlock> _blocks;
        private string _currentBlockId;
        private Dictionary<string, List<string>> _blockConnections;

        public TextBlockGraph()
        {
            _blocks = new Dictionary<string, TextBlock>();
            _currentBlockId = null;
            _blockConnections = new Dictionary<string, List<string>>();
        }

        public void AddBlock(TextBlock block)
        {
            _blocks[block.Id] = block;
        }

        public void AddConnection(string fromBlockId, string toBlockId)
        {
            if (!_blockConnections.ContainsKey(fromBlockId))
                _blockConnections[fromBlockId] = new List<string>();

            _blockConnections[fromBlockId].Add(toBlockId);
        }

        public void SetCurrentBlock(string blockId)
        {
            _currentBlockId = blockId;
        }

        public TextBlock GetCurrentBlock()
        {
            if (_currentBlockId != null && _blocks.ContainsKey(_currentBlockId))
                return _blocks[_currentBlockId];

            return null;
        }

        public bool IsValidOption(string optionId)
        {
            var currentBlock = GetCurrentBlock();
            if (currentBlock != null && currentBlock.Options.Contains(optionId))
                return true;

            return false;
        }

        public void MoveToBlock(string optionId)
        {
            var currentBlock = GetCurrentBlock();
            if (currentBlock != null && currentBlock.Options.Contains(optionId))
            {
                var nextBlockId = optionId;
                SetCurrentBlock(nextBlockId);
            }
        }

        public List<string> GetConnectedBlocks()
        {
            var currentBlock = GetCurrentBlock();
            if (currentBlock != null && _blockConnections.ContainsKey(_currentBlockId))
                return _blockConnections[_currentBlockId];

            return new List<string>();
        }
    }

}
