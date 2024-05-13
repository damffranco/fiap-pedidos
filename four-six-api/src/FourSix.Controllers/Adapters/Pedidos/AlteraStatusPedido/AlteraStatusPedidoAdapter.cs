using FourSix.Controllers.Presenters;
using FourSix.Controllers.ViewModels;
using FourSix.Domain.Entities.PedidoAggregate;
using FourSix.UseCases.UseCases.Pedidos.AlteraStatusPedido;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Pedidos.AlteraStatusPedido
{
    public class AlteraStatusPedidoAdapter : IAlteraStatusPedidoAdapter
    {
        private readonly Notification _notification;

        private readonly IAlteraStatusPedidoUseCase _useCase;

        public AlteraStatusPedidoAdapter(Notification notification,
            IAlteraStatusPedidoUseCase useCase)
        {
            _useCase = useCase;
            _notification = notification;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AlteraStatusPedidoResponse))]
        public async Task<AlteraStatusPedidoResponse> Alterar(Guid pedidoId, EnumStatusPedido statusId)
        {
            var model = new PedidoModel(await _useCase.Execute(pedidoId, statusId, DateTime.Now));

            return new AlteraStatusPedidoResponse(model);
        }
    }
}
