namespace Domain.Entities
{
    public class ComboProduto
    {
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public int IdCombo { get; set; }
        public Combo Combo { get; set; }
    }
}