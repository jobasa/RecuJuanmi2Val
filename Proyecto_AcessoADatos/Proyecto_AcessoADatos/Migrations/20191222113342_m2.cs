using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_AcessoADatos.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Apuestas",
                columns: new[] { "Id", "Cuota", "Dinero_apostado", "ID_MERCADO", "ID_USUARIOS", "Tipo_apuesta", "mercadoid" },
                values: new object[] { 1, 3m, 100f, 1, 1, "Aouesta Over", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "Equipo_Local", "Equipo_visitante" },
                values: new object[] { 1, "Valencia", "Ajax" });

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "id", "Cuota_over", "Cuota_under", "Dinero_over", "Dinero_under", "EventoId", "IDEvento", "tipo_mercado" },
                values: new object[] { 1, 2m, 2m, 3f, 3f, null, 1, "LaLiga" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "ID", "Apellido", "Edad", "Email", "Nombre" },
                values: new object[] { 1, "Banyuls", 20, "jobanyuls@gmail.com", "Joan" });

            migrationBuilder.InsertData(
                table: "Cuentas",
                columns: new[] { "ID", "Nombre_banco", "Num_tarjeta_vinculada", "Saldo_actual", "UsuarioId" },
                values: new object[] { 1, "La Caixa", "4000001234567899", 100m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apuestas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cuentas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mercados",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
