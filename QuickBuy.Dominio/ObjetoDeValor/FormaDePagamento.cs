using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaDePagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaDePagamento.Boleto; }
        }

        public bool EhCredito
        {
            get { return Id == (int)TipoFormaDePagamento.Credito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaDePagamento.Deposito; }
        }

        public bool EhNaoDefinido
        {
            get { return Id == (int)TipoFormaDePagamento.NaoDefinido; }
        }
    }
}
