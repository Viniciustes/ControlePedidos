using Domain.Interfaces;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Combo : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public bool Ativo { get; set; }

        public virtual List<Produto> Produtos { get; set; }

        public int IdImagem { get; set; }
        public virtual Imagem Imagem { get; set; }
    }
}