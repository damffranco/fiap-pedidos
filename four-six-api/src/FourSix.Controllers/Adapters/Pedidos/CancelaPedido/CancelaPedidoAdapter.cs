using FourSix.Controllers.Presenters;
using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Pedidos.CancelaPedido;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Pedidos.CancelaPedido
{
    public class CancelaPedidoAdapter : ICancelaPedidoAdapter
    {
        private readonly Notification _notification;

        private IActionResult _viewModel;
        private readonly ICancelaPedidoUseCase _useCase;

        public CancelaPedidoAdapter(Notification notification,
            ICancelaPedidoUseCase useCase)
        {
            _useCase = useCase;
            _notification = notification;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CancelaPedidoResponse))]
        public async Task<CancelaPedidoResponse> Cancelar(CancelaPedidoRequest pedido)
        {
            var model = new PedidoModel(await _useCase.Execute(pedido.PedidoId, pedido.DataCancelamento));

            return new CancelaPedidoResponse(model);
        }
    }
}
