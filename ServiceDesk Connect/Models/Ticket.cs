using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ServiceDesk_Connect.Models
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("user_name")]
        public string UserName { get; set; }

        [BsonElement("device_name")]
        public string DeviceName { get; set; }

        [BsonElement("priority")] 
        public string Priority { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}