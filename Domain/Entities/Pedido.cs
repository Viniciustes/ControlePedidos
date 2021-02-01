using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Pedido : BaseEntity
    {
        public string Numero { get; set; }

        public virtual List<ProdutoPedido> Produtos { get; set; }

        public decimal ValorPedido { get; set; }

        public TimeSpan Entrega { get; set; }

        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}