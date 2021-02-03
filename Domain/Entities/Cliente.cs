using Domain.Interfaces;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Cliente : BaseEntity, IAtivo
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public bool Ativo { get; set; }

        // For Mapping One To One
        public int IdEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }

        // For Mapping One To Many Bidirectional
        public virtual List<Pedido> Pedidos { get; set; }
    }
}