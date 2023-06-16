using Telegram.Bot;
using Telegram.Bot.Types;
using QuestBotOfMyLifeAndDreams;
using Telegram.Bot.Types.ReplyMarkups;

public class GameController
{
    private TextBlockGraph _textBlockGraph;
    private readonly ITelegramBotClient _telegramClient;

    public GameController(ITelegramBotClient telegramBotClient)
    {
        _telegramClient = telegramBotClient;
        _textBlockGraph = new TextBlockGraph();

        // Создание и добавление блоков текста
        var block1 = new TextBlock("0", "Текст блока 0");
        block1.AddOption("1");
        _textBlockGraph.AddBlock(block1);
        _textBlockGraph.SetCurrentBlock("1");




        var block1 = new TextBlock("1", "Текст блока 1");
        block1.AddOption("1C","1A");
        _textBlockGraph.AddBlock(block1);
        _textBlockGraph.SetCurrentBlock("1");

        

        var block1A = new TextBlock("1A", "Текст блока 1A");
        block1A.AddOption("1B","1C");
        _textBlockGraph.AddBlock(block1A);
        _textBlockGraph.SetCurrentBlock("1A");

        var block1B = new TextBlock("1B", "Текст блока 1B");
        block1B.AddOption("1C");
        _textBlockGraph.AddBlock(block1B);
        _textBlockGraph.SetCurrentBlock("1B");

        var block1C = new TextBlock("1C", "Текст блока 1C");
        block1C.AddOption("14","7");
        _textBlockGraph.AddBlock(block1C);
        _textBlockGraph.SetCurrentBlock("1C");

        var block2 = new TextBlock("2", "Текст блока 2");
        block2.AddOption("2A","2B");
        _textBlockGraph.AddBlock(block2);
        _textBlockGraph.SetCurrentBlock("2");

        var block2A = new TextBlock("2A", "Текст блока 2A");
        block2A.AddOption("2C","2B");
        _textBlockGraph.AddBlock(block2A);
        _textBlockGraph.SetCurrentBlock("2A");

        var block2B = new TextBlock("2B", "Текст блока 2B");
       
        _textBlockGraph.AddBlock(block2B);
        _textBlockGraph.SetCurrentBlock("2B");

        var block2C = new TextBlock("2C", "Текст блока 2C");
        block2C.AddOption("11","18");
        _textBlockGraph.AddBlock(block2C);
        _textBlockGraph.SetCurrentBlock("2C");

        var block3 = new TextBlock("3", "Текст блока 3");
        block3.AddOption("3A","8");
        _textBlockGraph.AddBlock(block3);
        _textBlockGraph.SetCurrentBlock("3");

        var block3A = new TextBlock("3A", "Текст блока 3A");
        
        _textBlockGraph.AddBlock(block3A);
        _textBlockGraph.SetCurrentBlock("3A");


        var block4 = new TextBlock("4", "Текст блока 4");
        block4.AddOption("4A","4B","6");
        _textBlockGraph.AddBlock(block4);
        _textBlockGraph.SetCurrentBlock("4");

        var block4A = new TextBlock("4A", "Текст блока 4A");
        block4A.AddOption("4B", "6");
        _textBlockGraph.AddBlock(block4A);
        _textBlockGraph.SetCurrentBlock("4A");

        var block4B = new TextBlock("4B", "Текст блока 4B");
        block4B.AddOption("4C","4D","6");
        _textBlockGraph.AddBlock(block4B);
        _textBlockGraph.SetCurrentBlock("4B");

        var block4C = new TextBlock("4C", "Текст блока 4C");
        block4C.AddOption("6");
        _textBlockGraph.AddBlock(block4C);
        _textBlockGraph.SetCurrentBlock("4C");

        var block4D = new TextBlock("4D", "Текст блока 4D");
        block4C.AddOption("6","4E");
        _textBlockGraph.AddBlock(block4D);
        _textBlockGraph.SetCurrentBlock("4D");

        var block4E = new TextBlock("4E", "Текст блока 4E");
        
        _textBlockGraph.AddBlock(block4E);
        _textBlockGraph.SetCurrentBlock("4E");

        var block5 = new TextBlock("5", "Текст блока 5");
        block5.AddOption("5A","5B");
        _textBlockGraph.AddBlock(block5);
        _textBlockGraph.SetCurrentBlock("5");

        var block5A = new TextBlock("5A", "Текст блока 5A");
        block5A.AddOption("12");
        _textBlockGraph.AddBlock(block5A);
        _textBlockGraph.SetCurrentBlock("5A");

        var block5B = new TextBlock("5B", "Текст блока 5B");
        
        _textBlockGraph.AddBlock(block5B);
        _textBlockGraph.SetCurrentBlock("5B");

        var block6 = new TextBlock("6", "Текст блока 6");
        block6.AddOption("6A", "6B", "9");
        _textBlockGraph.AddBlock(block6);
        _textBlockGraph.SetCurrentBlock("6");

        var block6A = new TextBlock("6A", "Текст блока 6A");
        block6A.AddOption("6C", "9");
        _textBlockGraph.AddBlock(block6A);
        _textBlockGraph.SetCurrentBlock("6A");

        var block6B = new TextBlock("6B", "Текст блока 6B");
        
        _textBlockGraph.AddBlock(block6B);
        _textBlockGraph.SetCurrentBlock("6B");

        var block6C = new TextBlock("6C", "Текст блока 6C");
        block6C.AddOption("17");
        _textBlockGraph.AddBlock(block6C);
        _textBlockGraph.SetCurrentBlock("6C");

        var block7 = new TextBlock("7", "Текст блока 7");
        block7.AddOption("7A","7C");
        _textBlockGraph.AddBlock(block7);
        _textBlockGraph.SetCurrentBlock("7");

        var block7A = new TextBlock("7A", "Текст блока 7A");
        block7A.AddOption("7B","7C");
        _textBlockGraph.AddBlock(block7A);
        _textBlockGraph.SetCurrentBlock("7A");

        var block7B = new TextBlock("7B", "Текст блока 7B");
        block7B.AddOption("7C");
        _textBlockGraph.AddBlock(block7B);
        _textBlockGraph.SetCurrentBlock("7B");

        var block7C = new TextBlock("7C", "Текст блока 7C");
        block7C.AddOption("14");
        _textBlockGraph.AddBlock(block7C);
        _textBlockGraph.SetCurrentBlock("7C");

        var block8 = new TextBlock("8", "Текст блока 8");
        block8.AddOption("8A","2","15");
        _textBlockGraph.AddBlock(block8);
        _textBlockGraph.SetCurrentBlock("8");

        var block8A = new TextBlock("8A", "Текст блока 8A");
        block8A.AddOption("8B","8C");
        _textBlockGraph.AddBlock(block8A);
        _textBlockGraph.SetCurrentBlock("8A");

        var block8B = new TextBlock("8B", "Текст блока 8B");
        
        _textBlockGraph.AddBlock(block8B);
        _textBlockGraph.SetCurrentBlock("8B");

        var block8C = new TextBlock("8C", "Текст блока 8C");
        block8C.AddOption("2","15");
        _textBlockGraph.AddBlock(block8C);
        _textBlockGraph.SetCurrentBlock("8C");

        var block9 = new TextBlock("9", "Текст блока 9");
        block9.AddOption("9A","9B");
        _textBlockGraph.AddBlock(block9);
        _textBlockGraph.SetCurrentBlock("9");

        var block9A = new TextBlock("9A", "Текст блока 9A");
        block9A.AddOption("3");
        _textBlockGraph.AddBlock(block9A);
        _textBlockGraph.SetCurrentBlock("9A");

        var block9B = new TextBlock("9B", "Текст блока 9B");
        
        _textBlockGraph.AddBlock(block9B);
        _textBlockGraph.SetCurrentBlock("9B");

        var block10 = new TextBlock("10", "Текст блока 10");
        block10.AddOption("10A","10B");
        _textBlockGraph.AddBlock(block10);
        _textBlockGraph.SetCurrentBlock("10");

        var block10A = new TextBlock("10A", "Текст блока 10A");
        block10A.AddOption("16","5");
        _textBlockGraph.AddBlock(block10A);
        _textBlockGraph.SetCurrentBlock("10A");

        var block10B = new TextBlock("10B", "Текст блока 10B");
        block10B.AddOption("10A");
        _textBlockGraph.AddBlock(block10B);
        _textBlockGraph.SetCurrentBlock("10B");

        var block11 = new TextBlock("11", "Текст блока 11");
        block11.AddOption("11A","11B");
        _textBlockGraph.AddBlock(block11);
        _textBlockGraph.SetCurrentBlock("11");

        var block11A = new TextBlock("11A", "Текст блока 11A");
        block11A.AddOption("5");
        _textBlockGraph.AddBlock(block11A);
        _textBlockGraph.SetCurrentBlock("11A");

        var block11B = new TextBlock("11B", "Текст блока 11B");
        block11B.AddOption("18");
        _textBlockGraph.AddBlock(block11B);
        _textBlockGraph.SetCurrentBlock("11B");


        var block12 = new TextBlock("12", "Текст блока 12");
        block12.AddOption("12A","2B");
        _textBlockGraph.AddBlock(block12);
        _textBlockGraph.SetCurrentBlock("12");

        var block12A = new TextBlock("12A", "Текст блока 12A");
        block12A.AddOption("12B","12D");
        _textBlockGraph.AddBlock(block12A);
        _textBlockGraph.SetCurrentBlock("12A");

        var block12B = new TextBlock("12B", "Текст блока 12B");
        block12B.AddOption("13");
        _textBlockGraph.AddBlock(block12B);
        _textBlockGraph.SetCurrentBlock("12B");

        var block12C = new TextBlock("12C", "Текст блока 12C");
        
        _textBlockGraph.AddBlock(block12C);
        _textBlockGraph.SetCurrentBlock("12C");

        var block12D = new TextBlock("12D", "Текст блока 12D");
        block12D.AddOption("12C");
        _textBlockGraph.AddBlock(block12B);
        _textBlockGraph.SetCurrentBlock("12B");

        var block13 = new TextBlock("13", "Текст блока 13");
        block13.AddOption("13A","13B");
        _textBlockGraph.AddBlock(block13);
        _textBlockGraph.SetCurrentBlock("13");

        var block13A = new TextBlock("13A", "Текст блока 13A");
        block13A.AddOption("20");
        _textBlockGraph.AddBlock(block13A);
        _textBlockGraph.SetCurrentBlock("13A");

        var block13B = new TextBlock("13B", "Текст блока 13B");
        
        _textBlockGraph.AddBlock(block13B);
        _textBlockGraph.SetCurrentBlock("13B");

        

        var block14 = new TextBlock("14", "Текст блока 14");
        block14.AddOption("14A","14B");
        _textBlockGraph.AddBlock(block14);
        _textBlockGraph.SetCurrentBlock("14");

        var block14A = new TextBlock("14A", "Текст блока 14A");
        block14A.AddOption("14C");
        _textBlockGraph.AddBlock(block14A);
        _textBlockGraph.SetCurrentBlock("14A");

        var block14B = new TextBlock("14B", "Текст блока 14B");
        block14B.AddOption("14A");
        _textBlockGraph.AddBlock(block14B);
        _textBlockGraph.SetCurrentBlock("14B");

        var block14C = new TextBlock("14C", "Текст блока 14C");
        block14C.AddOption("19","4");
        _textBlockGraph.AddBlock(block14C);
        _textBlockGraph.SetCurrentBlock("14C");

        var block15 = new TextBlock("15", "Текст блока 15");
        block15.AddOption("15A","15B");
        _textBlockGraph.AddBlock(block15);
        _textBlockGraph.SetCurrentBlock("15");

        var block15A = new TextBlock("15A", "Текст блока 15A");
        block15A.AddOption("2");
        _textBlockGraph.AddBlock(block15A);
        _textBlockGraph.SetCurrentBlock("15A");

        var block15B = new TextBlock("15B", "Текст блока 15B");
        block15B.AddOption("2");
        _textBlockGraph.AddBlock(block15B);
        _textBlockGraph.SetCurrentBlock("15B");

        var block16 = new TextBlock("16", "Текст блока 16");
        block16.AddOption("16A","5");
        _textBlockGraph.AddBlock(block16);
        _textBlockGraph.SetCurrentBlock("16");

        var block16A = new TextBlock("16A", "Текст блока 16A");
        block16A.AddOption("5");
        _textBlockGraph.AddBlock(block16A);
        _textBlockGraph.SetCurrentBlock("16A");


        var block17 = new TextBlock("17", "Текст блока 17");
        block17.AddOption("17A","17B");
        _textBlockGraph.AddBlock(block17);
        _textBlockGraph.SetCurrentBlock("17");

        var block17A = new TextBlock("17A", "Текст блока 17A");
        block17A.AddOption("9");
        _textBlockGraph.AddBlock(block17A);
        _textBlockGraph.SetCurrentBlock("17A");

        var block17B = new TextBlock("17B", "Текст блока 17B");
        block17B.AddOption("3");
        _textBlockGraph.AddBlock(block17B);
        _textBlockGraph.SetCurrentBlock("17B");

        var block18 = new TextBlock("18", "Текст блока 18");
        block18.AddOption("18A","18B");
        _textBlockGraph.AddBlock(block18);
        _textBlockGraph.SetCurrentBlock("18");

        var block18A = new TextBlock("18A", "Текст блока 18A");
        block18A.AddOption("18C");
        _textBlockGraph.AddBlock(block18A);
        _textBlockGraph.SetCurrentBlock("18A");

        var block18B = new TextBlock("18B", "Текст блока 18B");
        block18B.AddOption("18D");
        _textBlockGraph.AddBlock(block18B);
        _textBlockGraph.SetCurrentBlock("18B");

        var block18C = new TextBlock("18C", "Текст блока 18C");
        block18C.AddOption("18D","10");
        _textBlockGraph.AddBlock(block18C);
        _textBlockGraph.SetCurrentBlock("18C");

        var block18D = new TextBlock("18D", "Текст блока 18D");
        
        _textBlockGraph.AddBlock(block18D);
        _textBlockGraph.SetCurrentBlock("18D");

        var block19 = new TextBlock("19", "Текст блока 19");
        block19.AddOption("19A","6","4");
        _textBlockGraph.AddBlock(block19);
        _textBlockGraph.SetCurrentBlock("19");

        var block19A = new TextBlock("19A", "Текст блока 19A");
        block19A.AddOption("19B","19C");
        _textBlockGraph.AddBlock(block19A);
        _textBlockGraph.SetCurrentBlock("19A");

        var block19B = new TextBlock("19B", "Текст блока 19B");
        block19B.AddOption("19C");
        _textBlockGraph.AddBlock(block19B);
        _textBlockGraph.SetCurrentBlock("19B");

        var block19C = new TextBlock("19C", "Текст блока 19C");
        block19C.AddOption("6","4");
        _textBlockGraph.AddBlock(block19C);
        _textBlockGraph.SetCurrentBlock("19C");

        var block20 = new TextBlock("20", "Текст блока 20");
        block20.AddOption("20A","20B");
        _textBlockGraph.AddBlock(block20);
        _textBlockGraph.SetCurrentBlock("20");

        var block20A = new TextBlock("20A", "Текст блока 20A");
        block20A.AddOption("20C");
        _textBlockGraph.AddBlock(block20A);
        _textBlockGraph.SetCurrentBlock("20A");

        var block20B = new TextBlock("20B", "Текст блока 20B");
        
        _textBlockGraph.AddBlock(block20B);
        _textBlockGraph.SetCurrentBlock("20B");

        var block20C = new TextBlock("20C", "Текст блока 20C");
        block20C.AddOption("21");
        _textBlockGraph.AddBlock(block20C);
        _textBlockGraph.SetCurrentBlock("20C");

        var block21 = new TextBlock("21", "Текст блока 21");
        
        _textBlockGraph.AddBlock(block21);
        _textBlockGraph.SetCurrentBlock("21");



    }

    public async Task Handle(Message message)
    {
        var currentBlock = _textBlockGraph.GetCurrentBlock();

        if (currentBlock != null)
        {
            // Отправка текущего блока текста пользователю
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, currentBlock.Text);

            // Отправка вариантов выбора пользователю
            var replyKeyboardMarkup = new ReplyKeyboardMarkup(currentBlock.Options.Select(option => new KeyboardButton[] { option }));
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, "Выберите один из вариантов:", replyMarkup: replyKeyboardMarkup);

            // Ожидание выбора пользователя
            var response = await _telegramClient.GetUpdatesAsync();

            // Обработка выбора пользователя
            if (response.Length > 0 && response[0].Message != null)
            {
                var userChoice = response[0].Message.Text;

                if (_textBlockGraph.IsValidOption(userChoice))
                {
                    _textBlockGraph.MoveToBlock(userChoice);
                    await Handle(message);
                }
            }
        }
    }
}