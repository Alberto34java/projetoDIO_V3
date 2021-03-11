using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Formacao
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement]
        public string Nome { get; set; }
    }
}