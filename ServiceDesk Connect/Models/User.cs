using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServiceDesk_Connect.Models
{
    [BsonIgnoreExtraElements] 
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("telegram_id")] 
        public long TelegramId { get; set; }

        [BsonElement("password")] 
        public string Password { get; set; }
    }
}