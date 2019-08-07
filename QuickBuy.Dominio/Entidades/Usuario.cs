using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string  Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if(string.IsNullOrEmpty(Email))
            {
                AdicionarMensagemValidacao("Email não informado");
            }

            if(string.IsNullOrEmpty(Senha))
            {
                AdicionarMensagemValidacao("Senha não informada");
            }
        }
    }
}
