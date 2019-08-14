using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SiennaAidHub.Models
{
    public class IncomingData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Value")]
        public string Value { get; set; }
    }
}