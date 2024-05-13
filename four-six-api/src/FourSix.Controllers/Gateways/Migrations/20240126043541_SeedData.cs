using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourSix.Controllers.Gateways.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("63c776f5-4539-478e-a17a-54d3a1c2d3ee"),
                column: "Categoria",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("7686debb-92c2-4d89-a669-8988da8e8c72"),
                column: "Categoria",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("947e3d62-26fa-4ba6-8395-39c259fc43ec"),
                column: "Categoria",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("9482fcf0-e9e4-4bdc-869f-ad7d1d15016c"),
                column: "Categoria",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a0d0225e-0f3c-42ff-935d-beb44bb2cac4"),
                column: "Categoria",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a45a3af2-17db-459f-867a-b0c2e1261dc0"),
                column: "Categoria",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c2a49da0-6bc2-4cdc-be77-97d0284b8c92"),
                column: "Categoria",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c55a9ca7-411d-4245-8b91-1efbc30f7a9b"),
                column: "Categoria",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("d23c72b6-0bbe-4e0d-a46e-b8d72da5e9ef"),
                column: "Categoria",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("ea5df339-afd7-41b6-a4ab-44979c1d919d"),
                column: "Categoria",
                value: 3);

            migrationBuilder.InsertData(
                table: "StatusPagamento",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { (short)4, "Negado" });

            migrationBuilder.InsertData(
                table: "StatusPedido",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { (short)7, "Cancelado" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StatusPagamento",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "StatusPedido",
                keyColumn: "Id",
                keyValue: (short)7);

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: new Guid("78e3b8d0-be9a-4407-9304-c61788797808"),
                column: "DataPedido",
                value: new DateTime(2023, 10, 30, 19, 26, 39, 762, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "PedidoCheckout",
                keyColumns: new[] { "PedidoId", "Sequencia" },
                keyValues: new object[] { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), 0 },
                column: "DataStatus",
                value: new DateTime(2023, 10, 30, 19, 26, 39, 762, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("63c776f5-4539-478e-a17a-54d3a1c2d3ee"),
                column: "Categoria",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("7686debb-92c2-4d89-a669-8988da8e8c72"),
                column: "Categoria",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("947e3d62-26fa-4ba6-8395-39c259fc43ec"),
                column: "Categoria",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("9482fcf0-e9e4-4bdc-869f-ad7d1d15016c"),
                column: "Categoria",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a0d0225e-0f3c-42ff-935d-beb44bb2cac4"),
                column: "Categoria",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a45a3af2-17db-459f-867a-b0c2e1261dc0"),
                column: "Categoria",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c2a49da0-6bc2-4cdc-be77-97d0284b8c92"),
                column: "Categoria",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c55a9ca7-411d-4245-8b91-1efbc30f7a9b"),
                column: "Categoria",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("d23c72b6-0bbe-4e0d-a46e-b8d72da5e9ef"),
                column: "Categoria",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("ea5df339-afd7-41b6-a4ab-44979c1d919d"),
                column: "Categoria",
                value: 2);
        }
    }
}
