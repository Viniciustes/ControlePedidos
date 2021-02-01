using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Endereco : BaseEntity, IAtivo
    {
        public TipoEnderecoEnum TipoEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public bool Ativo { get; set; }

        public int IdCidade { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}