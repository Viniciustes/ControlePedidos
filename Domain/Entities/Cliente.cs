using Domain.Interfaces;

namespace Domain.Entities
{
    public class Cliente : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public bool Ativo { get; set; }

        public int IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}