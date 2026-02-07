using MongoDB.Driver;
using ServiceDesk_Connect.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System;

namespace ServiceDesk_Connect.Services
{
    public class DatabaseService
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Ticket> _tickets;
        private readonly IMongoCollection<Machine> _machines;
        private readonly IMongoCollection<User> _users;

        public DatabaseService()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            if (!File.Exists(path))
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), "../../..", ".env");
            }
            DotNetEnv.Env.Load(path);

            string connectionString = DotNetEnv.Env.GetString("MONGODB_CONNECTION_STRING")
                                   ?? DotNetEnv.Env.GetString("MONGO_CONNECTION_STRING");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Не знайдено рядок підключення у файлі .env! Перевірте файл.");
            }

            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("support_db");

            _tickets = _database.GetCollection<Ticket>("tickets");
            _machines = _database.GetCollection<Machine>("machines");
            _users = _database.GetCollection<User>("users");
        }

        public async Task InsertTicketAsync(Ticket ticket)
        {
            ticket.CreatedAt = System.DateTime.Now;
            await _tickets.InsertOneAsync(ticket);
        }

        public async Task<bool> AuthenticateAsync(long telegramId, string password)
        {
            try
            {
                var filter = Builders<User>.Filter.And(
                    Builders<User>.Filter.Eq(u => u.TelegramId, telegramId),
                    Builders<User>.Filter.Eq(u => u.Password, password)
                );
                var user = await _users.Find(filter).FirstOrDefaultAsync();
                return user != null;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<string>> GetActiveMachinesAsync()
        {
            var filter = Builders<Machine>.Filter.Eq(m => m.IsActive, true);
            var machines = await _machines.Find(filter).ToListAsync();
            return machines.Select(m => m.Name).ToList();
        }
    }
}