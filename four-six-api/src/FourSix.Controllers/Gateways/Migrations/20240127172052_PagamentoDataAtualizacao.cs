using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourSix.Controllers.Gateways.Migrations
{
    /// <inheritdoc />
    public partial class PagamentoDataAtualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Pagamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: new Guid("78e3b8d0-be9a-4407-9304-c61788797808"),
                column: "DataPedido",
                value: new DateTime(2024, 1, 27, 9, 20, 52, 247, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "PedidoCheckout",
                keyColumns: new[] { "PedidoId", "Sequencia" },
                keyValues: new object[] { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), 0 },
                column: "DataStatus",
                value: new DateTime(2024, 1, 27, 9, 20, 52, 247, DateTimeKind.Local).AddTicks(398));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Pagamento");

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: new Guid("78e3b8d0-be9a-4407-9304-c61788797808"),
                column: "DataPedido",
                value: new DateTime(2024, 1, 25, 20, 35, 41, 687, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "PedidoCheckout",
                keyColumns: new[] { "PedidoId", "Sequencia" },
                keyValues: new object[] { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), 0 },
                column: "DataStatus",
                value: new DateTime(2024, 1, 25, 20, 35, 41, 687, DateTimeKind.Local).AddTicks(3854));
        }
    }
}
