using FourSix.Controllers.Presenters;
using FourSix.UseCases.UseCases.Clientes.NovoCliente;
using FourSix.UseCases.UseCases.Clientes.ObtemCliente;
using FourSix.UseCases.UseCases.Pagamentos.AlterarStatusPagamento;
using FourSix.UseCases.UseCases.Pagamentos.BuscaPagamento;
using FourSix.UseCases.UseCases.Pagamentos.GeraPagamento;
using FourSix.UseCases.UseCases.Pagamentos.GeraQRCode;
using FourSix.UseCases.UseCases.Pedidos.AlteraStatusPedido;
using FourSix.UseCases.UseCases.Pedidos.CancelaPedido;
using FourSix.UseCases.UseCases.Pedidos.NovoPedido;
using FourSix.UseCases.UseCases.Pedidos.ObtemPedidos;
using FourSix.UseCases.UseCases.Pedidos.ObtemPedidosPorStatus;
using FourSix.UseCases.UseCases.Pedidos.ObtemStatusPagamentoPedido;
using FourSix.UseCases.UseCases.Produtos.AlteraProduto;
using FourSix.UseCases.UseCases.Produtos.InativaProduto;
using FourSix.UseCases.UseCases.Produtos.NovoProduto;
using FourSix.UseCases.UseCases.Produtos.ObtemProduto;
using FourSix.UseCases.UseCases.Produtos.ObtemProdutoPorCategoria;
using FourSix.UseCases.UseCases.Produtos.ObtemProdutos;

namespace FourSix.WebApi.Modules
{
    public static class UseCasesExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<Notification, Notification>();

            #region [ Clientes ]
            services.AddScoped<INovoClienteUseCase, NovoClienteUseCase>();
            services.AddScoped<IObtemClienteUseCase, ObtemClienteUseCase>();
            #endregion

            #region [ Produtos ]
            services.AddScoped<IAlteraProdutoUseCase, AlteraProdutoUseCase>();
            services.AddScoped<INovoProdutoUseCase, NovoProdutoUseCase>();
            services.AddScoped<IInativaProdutoUseCase, InativaProdutoUseCase>();
            services.AddScoped<IObtemProdutoUseCase, ObtemProdutoUseCase>();
            services.AddScoped<IObtemProdutosPorCategoriaUseCase, ObtemProdutosPorCategoriaUseCase>();
            services.AddScoped<IObtemProdutosUseCase, ObtemProdutosUseCase>();
            #endregion

            #region [ Pedidos ]
            services.AddScoped<IAlteraStatusPedidoUseCase, AlteraStatusPedidoUseCase>();
            services.AddScoped<ICancelaPedidoUseCase, CancelaPedidoUseCase>();
            services.AddScoped<INovoPedidoUseCase, NovoPedidoUseCase>();
            services.AddScoped<IObtemPedidosPorStatusUseCase, ObtemPedidosPorStatusUseCase>();
            services.AddScoped<IObtemPedidosUseCase, ObtemPedidosUseCase>();
            #endregion

            #region [ Pagamento ]
            services.AddScoped<IGeraQRCodeUseCase, GeraQRCodeUseCase>();
            services.AddScoped<IGeraPagamentoUseCase, GeraPagamentoUseCase>();
            services.AddScoped<IObtemStatusPagamentoPedidoUseCase, ObtemStatusPagamentoPedidoUseCase>();
            services.AddScoped<IBuscaPagamentoUseCase, BuscaPagamentoUseCase>();
            services.AddScoped<IAlterarStatusPagamentoUseCase, AlterarStatusPagamentoUseCase>();
            #endregion

            return services;
        }
    }
}
