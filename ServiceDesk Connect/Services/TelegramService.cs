using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace ServiceDesk_Connect.Services
{
    public class TelegramService
    {
        private readonly ITelegramBotClient _bot;

        public TelegramService()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            if (!File.Exists(path))
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), "../../..", ".env");
            }
            DotNetEnv.Env.Load(path);

            string token = DotNetEnv.Env.GetString("TELEGRAM_TOKEN");

            if (!string.IsNullOrEmpty(token))
            {
                _bot = new TelegramBotClient(token);
            }
        }

        public async Task<bool> SendNotificationAsync(string message, long chatId)
        {
            if (_bot == null) return false;

            try
            {
                await _bot.SendMessage(chatId, message, parseMode: ParseMode.Html);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка Телеграм: {ex.Message}");
                return false;
            }
        }
    }
}