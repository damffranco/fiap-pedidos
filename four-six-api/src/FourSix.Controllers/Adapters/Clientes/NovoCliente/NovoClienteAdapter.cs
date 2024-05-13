using FourSix.Controllers.Presenters;
using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Clientes.NovoCliente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Clientes.NovoCliente
{
    public class NovoClienteAdapter : INovoClienteAdapter
    {
        private readonly Notification _notification;

        private readonly INovoClienteUseCase _useCase;

        public NovoClienteAdapter(Notification notification,
            INovoClienteUseCase useCase)
        {
            _useCase = useCase;
            _notification = notification;
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(NovoClienteResponse))]
        public async Task<NovoClienteResponse> Inserir(NovoClienteRequest cliente)
        {
            var model = new ClienteModel(await _useCase.Execute(cliente.Cpf, cliente.NomeCompleto, cliente.Email));

            return new NovoClienteResponse(model);
        }
    }
}
