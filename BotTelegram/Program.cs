using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace BotTelegram
{
    internal class Program
    {
        static TelegramBotClient Bot = new TelegramBotClient("6352114543:AAG7oz22Wo0dNUMcSAoz0ZQxmt9Bcq5OUXc");
        static List<long> ChatIds = new List<long>();
        static List<string> questions = new List<string>()
        {
            "Erdogan ne vaxt hakimiyyetden geder?",
            "Telegram bot yaxsi biridir mi?",
            "Muellimin maasi ne qederdir?"
        };

        static List<string> answers = new List<string>()
        {
            "Olende",
            "Baxir veziyyete",
            "Kasibdi muellim"
        };
        // botfather - /mybots
        // /newbot
        static void Main(string[] args)
        {
            ReceiverOptions receiverOptions = new ReceiverOptions()
            {
                AllowedUpdates = new UpdateType[]
                {
                    UpdateType.Message
                }
            };
            Bot.StartReceiving(UpdateHandler, ErrorHandler, receiverOptions);
            Console.ReadLine();
        }

        private async static Task ErrorHandler(ITelegramBotClient client, Exception ex, CancellationToken arg3)
        {
            await Console.Out.WriteLineAsync(ex.Message);
        }

        private async static Task UpdateHandler(ITelegramBotClient client, Update update, 
                                                CancellationToken cancellationtoken)
        {
            //if (!ChatIds.Contains(update.Message.Chat.Id))
            //{
            //    ChatIds.Add(update.Message.Chat.Id);
            //}
            //string textMessage = update.Message.Text;
            //string username = update.Message.Chat.FirstName + " " + update.Message.Chat.LastName;
            //string response = $"User : {username} \n Message : {textMessage}";
            //foreach (long chatid in ChatIds)
            //{
            //    await client.SendTextMessageAsync(chatid, response);
            //}

            long chatId = update.Message.Chat.Id;
            string message = update.Message.Text;
            int questionId = questions.IndexOf(message);
            if(questionId == -1)
            {
                await client.SendTextMessageAsync(chatId, "Bu sualin cavabini bilmirem");
            }
            else
            {
                await client.SendTextMessageAsync(chatId, answers[questionId]);
            }
        }
    }
}