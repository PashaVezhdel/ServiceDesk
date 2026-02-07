using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServiceDesk_Connect.Models
{
    public class Machine
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("department")]
        public string Department { get; set; }

        [BsonElement("is_active")]
        public bool IsActive { get; set; }
    }
}