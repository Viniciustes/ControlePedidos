using Domain.Interfaces;

namespace Domain.Entities
{
    public class ProdutoCategoria : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}