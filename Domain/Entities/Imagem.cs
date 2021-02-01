namespace Domain.Entities
{
    public class Imagem : BaseEntity
    {
        public string Nome { get; set; }

        public string Arquivo { get; set; }

        public bool Principal { get; set; }
    }
}