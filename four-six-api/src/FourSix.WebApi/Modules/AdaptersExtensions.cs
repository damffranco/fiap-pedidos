using FourSix.Controllers.Adapters.Clientes.NovoCliente;
using FourSix.Controllers.Adapters.Clientes.ObtemCliente;
using FourSix.Controllers.Adapters.Pagamentos.AlteraStatusPagamento;
using FourSix.Controllers.Adapters.Pagamentos.BuscaPagamento;
using FourSix.Controllers.Adapters.Pagamentos.GeraPagamento;
using FourSix.Controllers.Adapters.Pedidos.AlteraStatusPedido;
using FourSix.Controllers.Adapters.Pedidos.CancelaPedido;
using FourSix.Controllers.Adapters.Pedidos.NovoPedido;
using FourSix.Controllers.Adapters.Pedidos.ObtemPedidos;
using FourSix.Controllers.Adapters.Pedidos.ObtemPedidosPorStatus;
using FourSix.Controllers.Adapters.Pedidos.ObtemStatusPagamentoPedido;
using FourSix.Controllers.Adapters.Produtos.AlteraProduto;
using FourSix.Controllers.Adapters.Produtos.InativaProduto;
using FourSix.Controllers.Adapters.Produtos.NovoProduto;
using FourSix.Controllers.Adapters.Produtos.ObtemProduto;
using FourSix.Controllers.Adapters.Produtos.ObtemProdutos;
using FourSix.Controllers.Adapters.Produtos.ObtemProdutosPorCategoria;

namespace FourSix.WebApi.Modules
{
    public static class AdaptersExtensions
    {
        public static IServiceCollection AddAdapters(this IServiceCollection services)
        {
            #region [ Clientes ]
            services.AddScoped<INovoClienteAdapter, NovoClienteAdapter>();
            services.AddScoped<IObtemClienteAdapter, ObtemClienteAdapter>();
            #endregion

            #region [ Pagamentos ]
            services.AddScoped<IBuscaPagamentoAdapter, BuscaPagamentoAdapter>();
            services.AddScoped<IGeraPagamentoAdapter, GeraPagamentoAdapter>();
            services.AddScoped<IObtemStatusPagamentoPedidoAdapter, ObtemStatusPagamentoPedidoAdapter>();
            services.AddScoped<IAlteraStatusPagamentoAdapter, AlteraStatusPagamentoAdapter>();
            #endregion

            #region [ Pedidos ]
            services.AddScoped<IAlteraStatusPedidoAdapter, AlteraStatusPedidoAdapter>();
            services.AddScoped<ICancelaPedidoAdapter, CancelaPedidoAdapter>();
            services.AddScoped<INovoPedidoAdapter, NovoPedidoAdapter>();
            services.AddScoped<IObtemPedidosPorStatusAdapter, ObtemPedidosPorStatusAdapter>();
            services.AddScoped<IObtemPedidosAdapter, ObtemPedidosAdapter>();
            #endregion

            #region [ Produtos ]
            services.AddScoped<IAlteraProdutoAdapter, AlteraProdutoAdapter>();
            services.AddScoped<IInativaProdutoAdapter, InativaProdutoAdapter>();
            services.AddScoped<INovoProdutoAdapter, NovoProdutoAdapter>();
            services.AddScoped<IObtemProdutoAdapter, ObtemProdutoAdapter>();
            services.AddScoped<IObtemProdutosPorCategoriaAdapter, ObtemProdutosPorCategoriaAdapter>();
            services.AddScoped<IObtemProdutosAdapter, ObtemProdutosAdapter>();
            #endregion

            return services;
        }
    }
}
