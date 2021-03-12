using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Curso
    {
         [BsonRequired]
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
       public string Id { get; set; }   
       [BsonElement]
       public string  Nome { get; set; }
        [BsonElement]
        [BsonRequired]
       public string  Descricao { get; set; }
        [BsonElement]
         [BsonRequired]
       public string Duracao { get; set; }
       public Formacao Formacao { get; set; }
       public string FormacaoId { get; set; }
    }
}