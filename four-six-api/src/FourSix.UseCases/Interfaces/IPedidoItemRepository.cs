using FourSix.Domain.Entities.PedidoAggregate;

namespace FourSix.UseCases.Interfaces
{
    public interface IPedidoItemRepository : IGetRepository<PedidoItem, Guid>, ISetRepository<PedidoItem>
    {
    }
}
