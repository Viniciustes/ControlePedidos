namespace Domain.Entities
{
    public class ProdutoPedido : BaseEntity
    {
        public int Quantidade { get; set; }

        public decimal Preco { get; set; }

        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
    }
}