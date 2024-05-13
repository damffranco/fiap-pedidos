using FourSix.Domain.Entities.PedidoAggregate;
using FourSix.UseCases.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourSix.Controllers.Gateways.Repositories
{
    public class PedidoItemRepository : BaseRepository<PedidoItem, Guid>, IPedidoItemRepository
    {
        public PedidoItemRepository(DbContext context) : base(context)
        {
        }
    }
}
