﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ATodoRuedas.Migrations
{
    public partial class ActualizacionAutoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Auto_ClienteId",
                table: "Auto",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_cliente_ClienteId",
                table: "Auto",
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

            migrationBuilder.DropIndex(
                name: "IX_Auto_ClienteId",
                table: "Auto");
        }
    }
}
