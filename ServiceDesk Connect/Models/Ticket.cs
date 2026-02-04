using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServiceDesk_Connect.Models
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } 

        [BsonElement("device")]
        public string? DeviceName { get; set; }

        [BsonElement("user")]
        public string? UserName { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; }

        [BsonElement("photo_url")]
        public string? PhotoPath { get; set; } 

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}