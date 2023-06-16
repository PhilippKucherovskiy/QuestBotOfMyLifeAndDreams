using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestBotOfMyLifeAndDreams
{
    public class TextBlock
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public List<string> Options { get; set; }

        public TextBlock(string id, string text)
        {
            Id = id;
            Text = text;
            Options = new List<string>();
        }

        public void AddOption(string optionId, string v)
        {
            Options.Add(optionId);
        }
    }

}
