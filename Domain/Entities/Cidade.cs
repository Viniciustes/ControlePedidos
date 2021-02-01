using Domain.Interfaces;

namespace Domain.Entities
{
    public class Cidade : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public string UF { get; set; }

        public bool Ativo { get; set; }
    }
}