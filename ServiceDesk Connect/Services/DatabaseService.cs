using MongoDB.Bson;
using MongoDB.Driver;
using ServiceDesk_Connect.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDesk_Connect.Services
{
    public class DatabaseService
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Ticket> _tickets;

        public DatabaseService()
        {
            DotNetEnv.Env.Load();
            var client = new MongoClient(DotNetEnv.Env.GetString("MONGO_CONNECTION_STRING"));
            _database = client.GetDatabase("support_db");
            _tickets = _database.GetCollection<Ticket>("tickets");
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
                var usersCollection = _database.GetCollection<User>("users");
                var user = await usersCollection
                    .Find(u => u.TelegramId == telegramId && u.Password == password)
                    .FirstOrDefaultAsync();
                return user != null;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<string>> GetMachinesListAsync()
        {
            try
            {
                var collection = _database.GetCollection<BsonDocument>("machines");
                var documents = await collection.Find(new BsonDocument()).ToListAsync();
                return documents.Select(d => d["name"].ToString()).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}