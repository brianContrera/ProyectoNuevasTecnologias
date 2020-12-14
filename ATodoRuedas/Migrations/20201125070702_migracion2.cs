using Microsoft.EntityFrameworkCore.Migrations;

namespace ATodoRuedas.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_cliente_Clienteid",
                table: "Auto");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_cliente_Clienteid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Auto");

            migrationBuilder.RenameColumn(
                name: "Clienteid",
                table: "Factura",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_Clienteid",
                table: "Factura",
                newName: "IX_Factura_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Clienteid",
                table: "Auto",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Auto_Clienteid",
                table: "Auto",
                newName: "IX_Auto_ClienteId");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Factura",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Auto",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_cliente_ClienteId",
                table: "Auto",
                column: "ClienteId",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_cliente_ClienteId",
                table: "Factura",
                column: "ClienteId",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_cliente_ClienteId",
                table: "Auto");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_cliente_ClienteId",
                table: "Factura");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Factura",
                newName: "Clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_ClienteId",
                table: "Factura",
                newName: "IX_Factura_Clienteid");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Auto",
                newName: "Clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Auto_ClienteId",
                table: "Auto",
                newName: "IX_Auto_Clienteid");

            migrationBuilder.AlterColumn<int>(
                name: "Clienteid",
                table: "Factura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Clienteid",
                table: "Auto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Auto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_cliente_Clienteid",
                table: "Auto",
                column: "Clienteid",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_cliente_Clienteid",
                table: "Factura",
                column: "Clienteid",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
