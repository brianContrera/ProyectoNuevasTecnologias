using Microsoft.EntityFrameworkCore.Migrations;

namespace ATodoRuedas.Migrations
{
    public partial class migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    dni = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patente = table.Column<string>(nullable: false),
                    km = table.Column<double>(nullable: false),
                    anioFab = table.Column<int>(nullable: false),
                    modelo = table.Column<string>(nullable: false),
                    precio = table.Column<double>(nullable: false),
                    idCliente = table.Column<int>(nullable: false),
                    Clienteid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.id);
                    table.ForeignKey(
                        name: "FK_Auto_cliente_Clienteid",
                        column: x => x.Clienteid,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    idFactura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoFactura = table.Column<int>(nullable: false),
                    importe = table.Column<double>(nullable: false),
                    idCliente = table.Column<int>(nullable: false),
                    Clienteid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.idFactura);
                    table.ForeignKey(
                        name: "FK_Factura_cliente_Clienteid",
                        column: x => x.Clienteid,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_Clienteid",
                table: "Auto",
                column: "Clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Clienteid",
                table: "Factura",
                column: "Clienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
