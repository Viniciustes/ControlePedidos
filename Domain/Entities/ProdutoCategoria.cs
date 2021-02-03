using Domain.Interfaces;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ProdutoCategoria : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}