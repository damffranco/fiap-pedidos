using FourSix.Domain.Entities.ClienteAggregate;
using FourSix.Domain.Entities.ProdutoAggregate;

namespace FourSix.Domain.Entities.PedidoAggregate
{
    public class Pedido : BaseEntity, IAggregateRoot, IBaseEntity
    {
        private readonly List<PedidoItem> _pedidoItens = new();
        private readonly List<PedidoCheckout> _pedidoCheckout = new();

        public Pedido() { }

        public Pedido(Guid id, DateTime dataPedido, Guid? clienteId, ICollection<PedidoItem> itens, ICollection<PedidoCheckout> checkouts)
        {
            Id = id;
            DataPedido = dataPedido;
            ClienteId = clienteId;
            _pedidoItens = itens?.ToList();
            _pedidoCheckout = checkouts?.ToList();
        }

        public int NumeroPedido { get; }
        public Guid? ClienteId { get; }
        public DateTime DataPedido { get; }
        public EnumStatusPedido StatusId { get; private set; } = EnumStatusPedido.Recebido;
        public IReadOnlyCollection<PedidoItem> Itens => _pedidoItens;
        public IReadOnlyCollection<PedidoCheckout> HistoricoCheckout => _pedidoCheckout;
        public int TotalItens => _pedidoItens.Sum(i => i.Quantidade);
        public decimal ValorTotal => _pedidoItens.Sum(i => i.ValorUnitario * i.Quantidade);
        public Cliente Cliente { get; set; }
        public StatusPedido Status { get; set; }

        public void AdicionarItem(Produto produto, decimal valorUnitario, int quantidade = 1, string? observacao = null)
        {
            if (!Itens.Any(i => i.ItemPedido.Id == produto.Id))
            {
                _pedidoItens.Add(new PedidoItem(Id, produto.Id, valorUnitario, quantidade, observacao));
                return;
            }
            var itemExistente = Itens.First(i => i.ItemPedido.Id == produto.Id);
            itemExistente.AdicionarQuantidade(quantidade);
        }

        public void AlterarStatus(EnumStatusPedido statusId)
        {
            StatusId = statusId;
        }
    }
}
