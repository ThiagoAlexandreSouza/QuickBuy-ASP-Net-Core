using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get
            {
                return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());
            }
        }
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
        public abstract void Validate();

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagemValidacao(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
    }
}
