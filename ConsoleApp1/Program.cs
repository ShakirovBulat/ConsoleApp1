using System;
using System.IO;
using Telegram.Bot;

namespace TelegramBot
{
    class Program
    {
        static void Main(string[] args)
        {

            TelegramBotClient bot = new TelegramBotClient("1776821419:AAE1N2lCsSpOrfdt57W4K9F6wa7v7hoBqdg");

            bot.OnMessage += (s, arg) =>
            {
                Console.WriteLine($"{arg.Message.Chat.FirstName}: {arg.Message.Text}");
                bot.SendTextMessageAsync(arg.Message.Chat.Id, $"You say: {arg.Message.Text}");
            };

            bot.StartReceiving();

            Console.ReadKey();
        }
    }
}