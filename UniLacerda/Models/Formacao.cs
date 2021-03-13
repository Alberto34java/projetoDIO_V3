using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Formacao
    {
         [BsonRequired]
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
         [BsonRequired]
        [BsonElement]
        public string Nome { get; set; }
        
    }
}