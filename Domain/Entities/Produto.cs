using Domain.Interfaces;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Produto : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public bool Ativo { get; set; }

        public int IdCategoria { get; set; }
        public virtual ProdutoCategoria Categoria { get; set; }

        public virtual List<Imagem> Imagens { get; set; }
    }
}