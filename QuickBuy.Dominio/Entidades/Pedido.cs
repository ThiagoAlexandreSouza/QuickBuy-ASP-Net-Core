using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaDePagamento FormaPagamento { get; set; }

        public override void Validate()
        {
            if(!ItensPedido.Any())
            {
                LimparMensagensValidacao();
                if (!ItensPedido.Any())
                {
                    AdicionarMensagemValidacao("O pedido deve conter itens de pedido");
                }
                
                if(string.IsNullOrEmpty(CEP))
                {
                    AdicionarMensagemValidacao("O CEP Deve estar preenchido");
                }


            }
        }
    }
}
