using FourSix.Controllers.Presenters;
using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Clientes.ObtemCliente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Clientes.ObtemCliente
{
    public class ObtemClienteAdapter : IObtemClienteAdapter
    {
        private readonly Notification _notification;

        private readonly IObtemClienteUseCase _useCase;

        public ObtemClienteAdapter(Notification notification,
            IObtemClienteUseCase useCase)
        {
            this._useCase = useCase;
            this._notification = notification;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ObtemClienteResponse))]
        public async Task<ObtemClienteResponse> Obter(string cpf)
        {
            var model = new ClienteModel(await _useCase.Execute(cpf));

            return new ObtemClienteResponse(model);
        }
    }
}
