using FourSix.Controllers.Gateways.Configurations;
using FourSix.Domain.Entities.ClienteAggregate;
using FourSix.Domain.Entities.PagamentoAggregate;
using FourSix.Domain.Entities.PedidoAggregate;
using FourSix.Domain.Entities.ProdutoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FourSix.Controllers.Gateways.DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
        public DbSet<PedidoCheckout> PedidosCheckouts { get; set; }
        public DbSet<PedidoItem> PedidosItens { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<StatusPagamento> StatusPagamentos { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new PagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoItemConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoCheckoutConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new StatusPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new StatusPagamentoConfiguration());
            SeedData.Seed(modelBuilder);
        }
    }
}
