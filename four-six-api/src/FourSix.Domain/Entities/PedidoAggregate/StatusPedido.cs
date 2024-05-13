namespace FourSix.Domain.Entities.PedidoAggregate
{
    public enum EnumStatusPedido
    {
        Recebido = 1,
        Pago = 2,
        EmPreparacao = 3,
        Montagem = 4,
        Pronto = 5,
        Finalizado = 6,
        Cancelado = 7
    }

    public class StatusPedido
    {
        public EnumStatusPedido Id { get; }
        public string Descricao { get; }
    }
}
