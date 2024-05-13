using FourSix.Controllers.Adapters.Pedidos.ObtemPedidosPorStatus;
using FourSix.Controllers.Presenters;
using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Pedidos.ObtemPedidos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Pedidos.ObtemPedidos
{
    public class ObtemPedidosAdapter
        : IObtemPedidosAdapter
    {
        private readonly Notification _notification;

        private readonly IObtemPedidosUseCase _useCase;

        public ObtemPedidosAdapter(Notification notification,
            IObtemPedidosUseCase useCase)
        {
            _useCase = useCase;
            _notification = notification;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ObtemPedidosResponse))]
        public async Task<ObtemPedidosResponse> Listar()
        {
            var lista = await _useCase.Execute();

            var model = new List<PedidoModel>();
            lista.ToList().ForEach(f => model.Add(new PedidoModel(f)));

            return new ObtemPedidosResponse(model);
        }
    }
}
