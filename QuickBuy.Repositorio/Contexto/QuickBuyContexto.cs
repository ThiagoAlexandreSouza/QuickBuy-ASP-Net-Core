using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaDePagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de Mapeamento Aqui...

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaDePagamento>().HasData(
                new FormaDePagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de pagamento Boleto"
                },
                new FormaDePagamento()
                {
                    Id = 2,
                    Nome = "Credito",
                    Descricao = "Forma de pagamento credito"
                },
                new FormaDePagamento()
                {
                    Id = 3,
                    Nome = "Deposito",
                    Descricao = "Forma de pagamento Deposito"
                });



            base.OnModelCreating(modelBuilder);
        }
    }
}
