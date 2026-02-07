using System;
using System.IO;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ServiceDesk_Connect.Services
{
    public class TelegramService
    {
        private readonly ITelegramBotClient _bot;
        private readonly long _chatId;

        public TelegramService()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            if (!File.Exists(path))
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), "../../..", ".env");
            }
            DotNetEnv.Env.Load(path);

            string token = DotNetEnv.Env.GetString("TELEGRAM_BOT_TOKEN");
            string chatIdString = DotNetEnv.Env.GetString("TELEGRAM_CHAT_ID");

            if (!string.IsNullOrEmpty(token) && !string.IsNullOrEmpty(chatIdString))
            {
                _chatId = long.Parse(chatIdString);
                _bot = new TelegramBotClient(token);
            }
        }
    }
}