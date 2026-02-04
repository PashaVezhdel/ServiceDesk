using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ServiceDesk_Connect.Services
{
    public class TelegramService
    {
        private readonly string _token;
        private readonly string _chatId;

        public TelegramService()
        {
            DotNetEnv.Env.Load();
            _token = DotNetEnv.Env.GetString("TELEGRAM_TOKEN");
            _chatId = DotNetEnv.Env.GetString("TELEGRAM_CHAT_ID");
        }

        public async Task<bool> SendNotificationAsync(string user, string device, string desc)
        {
            try
            {
                using var client = new HttpClient();
                var data = new Dictionary<string, string>
                {
                    { "chat_id", _chatId },
                    { "parse_mode", "Markdown" },
                    { "text", $"🆕 *ЗАЯВКА*\n\n👤 {user}\n💻 {device}\n📝 {desc}" }
                };
                var res = await client.PostAsync($"https://api.telegram.org/bot{_token}/sendMessage", new FormUrlEncodedContent(data));
                return res.IsSuccessStatusCode;
            }
            catch { return false; }
        }
    }
}