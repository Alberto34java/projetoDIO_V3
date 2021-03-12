namespace Models
{
    public class Curso
    {
       public string Id { get; set; }   
       public string  Nome { get; set; }
       public string  Descricao { get; set; }
       public string Duracao { get; set; }
       public Formacao Formacao { get; set; }
       public string FormacaoId { get; set; }
    }
}