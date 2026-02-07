using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServiceDesk_Connect.Models
{
    public class Mechanic
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("telegram_id")]
        public long TelegramId { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }
}