using Domain.Interfaces;
using System;

namespace Domain.Entities
{
    public class ProdutoPromocao : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public DateTime DataValidadePromocao { get; set; }

        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public int IdImagem { get; set; }
        public virtual Imagem Imagem { get; set; }

        public bool Ativo { get; set; }
    }
}