﻿using FourSix.Controllers.Presenters;
using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Pedidos.NovoPedido;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Pedidos.NovoPedido
{
    public class NovoPedidoAdapter : INovoPedidoAdapter
    {
        private readonly Notification _notification;

        private readonly INovoPedidoUseCase _useCase;

        public NovoPedidoAdapter(Notification notification,
            INovoPedidoUseCase useCase)
        {
            _useCase = useCase;
            _notification = notification;
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(NovoPedidoResponse))]
        public async Task<NovoPedidoResponse> Inserir(NovoPedidoRequest pedido)
        {
            var model = new PedidoModel(await _useCase.Execute(pedido.DataPedido, pedido.ClienteId, pedido.Items.Select(i => new Tuple<Guid, decimal, int, string>(i.ItemPedidoId, i.ValorUnitario, i.Quantidade, i.Observacao)).ToList()));

            return new NovoPedidoResponse(model);
        }
    }
}
