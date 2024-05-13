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
using FourSix.Domain.Entities.PedidoAggregate;
using FourSix.Domain.Entities.ProdutoAggregate;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace FourSix.WebApi.Modules
{
    public static class RoutesExtensions
    {
        public static void AddRoutesMaps(this IEndpointRouteBuilder app)
        {
            #region [ Clientes ]

            app.MapGet("clientes/{cpf}",
            [SwaggerOperation(Summary = "Obtém cliente")]
            ([SwaggerParameter("CPF do cliente")] string cpf, IObtemClienteAdapter adapter) =>
            {
                return adapter.Obter(cpf);
            }).WithTags("Clientes");

            app.MapPost("clientes",
            [SwaggerOperation(Summary = "Cria novo cliente")]
            ([FromBody] NovoClienteRequest request, INovoClienteAdapter adapter) =>
            {
                return adapter.Inserir(request);
            }).WithTags("Clientes");

            #endregion

            #region [ Pedidos ]

            app.MapGet("pedidos",
            [SwaggerOperation(Summary = "Obtém lista de pedido")]
            (IObtemPedidosAdapter adapter) =>
            {
                return adapter.Listar();
            }).WithTags("Pedidos").AllowAnonymous();

            app.MapGet("pedidos/{statusId}",
            [SwaggerOperation(Summary = "Obtém lista de pedido por status")]
            ([SwaggerParameter("Status do pedido<br><br>Recebido = 1<br>Pago = 2<br>EmPreparacao = 3<br>Montagem = 4<br>Pronto = 5<br>Finalizado = 6<br>Cancelado = 7")] EnumStatusPedido statusId, IObtemPedidosPorStatusAdapter adapter) =>
            {
                return adapter.Listar(statusId);
            }).WithTags("Pedidos");

            app.MapPost("pedidos/anonymous",
            [SwaggerOperation(Summary = "Cria novo pedido")]
            ([FromBody] NovoPedidoRequest request, INovoPedidoAdapter adapter) =>
            {
                return adapter.Inserir(request);
            }).WithTags("Pedidos").AllowAnonymous();

            app.MapPost("pedidos",
            [SwaggerOperation(Summary = "Cria novo pedido")]
            ([FromBody] NovoPedidoRequest request, INovoPedidoAdapter adapter) =>
            {
                return adapter.Inserir(request);
            }).WithTags("Pedidos").RequireAuthorization();

            app.MapPut("pedidos/cancelamentos/anonymous",
            [SwaggerOperation(Summary = "Cancela pedido")]
            ([FromBody] CancelaPedidoRequest request, ICancelaPedidoAdapter adapter) =>
            {
                return adapter.Cancelar(request);
            }).WithTags("Pedidos").AllowAnonymous();

            app.MapPut("pedidos/{pedidoId:Guid}/status/{statusId}",
            [SwaggerOperation(Summary = "Altera status do pedido")]
            ([SwaggerParameter("ID do Pedido")] Guid pedidoId, [SwaggerParameter("Status do pedido<br><br>Recebido = 1<br>Pago = 2<br>EmPreparacao = 3<br>Montagem = 4<br>Pronto = 5<br>Finalizado = 6<br>Cancelado = 7")] EnumStatusPedido statusId, IAlteraStatusPedidoAdapter adapter) =>
            {
                return adapter.Alterar(pedidoId, statusId);
            }).WithTags("Pedidos").AllowAnonymous(); ;

            app.MapGet("pedidos/{pedidoId:Guid}/pagamentos",
            [SwaggerOperation(Summary = "Obtém o status do pagamento do pedido")]
            ([SwaggerParameter("Id do pedido")] Guid pedidoId, IObtemStatusPagamentoPedidoAdapter adapter) =>
            {
                return adapter.ObterStatusPagamento(pedidoId);
            }).WithTags("Pedidos").AllowAnonymous(); ;

            #endregion

            #region [ Pagamentos ]

            app.MapPost("pagamentos",
            [SwaggerOperation(Summary = "Gera novo pagamento")]
            ([SwaggerParameter("Dados do pagamento")][FromBody] GeraPagamentoRequest request, IGeraPagamentoAdapter adapter) =>
            {
                return adapter.Gerar(request);
            }).WithTags("Pagamentos").AllowAnonymous(); ;

            app.MapPut("pagamentos/{pagamentoId:Guid}/status",
            [SwaggerOperation(Summary = "Altera o status do pagamento")]
            ([SwaggerParameter("Id do pagamento")] Guid pagamentoId,
            [SwaggerParameter("Dados do pagamento")][FromBody] AlteraStatusPagamentRequest request, IAlteraStatusPagamentoAdapter adapter) =>
            {
                return adapter.AlterarStatus(request, pagamentoId);
            }).WithTags("Pagamentos").AllowAnonymous(); ;

            app.MapGet("pagamentos/{pagamentoId:Guid}",
            [SwaggerOperation(Summary = "Obtém o pagamento")]
            ([SwaggerParameter("Id do pagamento")] Guid pagamentoId, IBuscaPagamentoAdapter adapter) =>
            {
                return adapter.Buscar(pagamentoId);
            }).WithTags("Pagamentos").AllowAnonymous(); ;

            #endregion

            #region [ Produtos ]

            app.MapPut("produtos/{produtoId:guid}",
            [SwaggerOperation(Summary = "Altera produto")]
            ([SwaggerParameter("Id do produto")] Guid produtoId, [FromBody] AlteraProdutoRequest request, IAlteraProdutoAdapter adapter) =>
            {
                return adapter.Alterar(produtoId, request);
            }).WithTags("Produtos").AllowAnonymous(); ;

            app.MapDelete("produtos/{produtoId:guid}",
            [SwaggerOperation(Summary = "Inativa produto")]
            ([SwaggerParameter("Id do produto")] Guid produtoId, IInativaProdutoAdapter adapter) =>
            {
                return adapter.Inativar(produtoId);
            }).WithTags("Produtos").AllowAnonymous(); ;

            app.MapPost("produtos",
            [SwaggerOperation(Summary = "Insere novo produto")]
            ([FromBody] NovoProdutoRequest request, INovoProdutoAdapter adapter) =>
            {
                return adapter.Inserir(request);
            }).WithTags("Produtos").AllowAnonymous(); ;

            app.MapGet("produtos/{produtoId:guid}",
            [SwaggerOperation(Summary = "Obtém o produto")]
            ([SwaggerParameter("Id do produto")] Guid produtoId, IObtemProdutoAdapter adapter) =>
            {
                return adapter.Obter(produtoId);
            }).WithTags("Produtos").AllowAnonymous(); ;

            app.MapGet("produtos/{categoria}",
            [SwaggerOperation(Summary = "Obtém o produto por categoria")]
            ([SwaggerParameter("Categoria do produto<br><br>Lanche = 1<br>Acompanhamento = 2<br>Sobremesa = 3<br>Bebida = 4")] EnumCategoriaProduto categoria, IObtemProdutosPorCategoriaAdapter adapter) =>
            {
                return adapter.Obter(categoria);
            }).WithTags("Produtos").AllowAnonymous(); ;

            app.MapGet("produtos",
            [SwaggerOperation(Summary = "Lista os produto")]
            (IObtemProdutosAdapter adapter) =>
            {
                return adapter.Listar();
            }).WithTags("Produtos").AllowAnonymous(); ;

            #endregion
        }
    }
}
