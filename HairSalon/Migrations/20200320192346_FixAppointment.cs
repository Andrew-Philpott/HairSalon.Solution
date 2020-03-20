using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HairSalon.Migrations
{
    public partial class FixAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Appointments_AppointmentId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AppointmentId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Clients");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Appointments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clients_ClientId",
                table: "Appointments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clients_ClientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Appointments");

            migrationBuilder.AddColumn<Guid>(
                name: "AppointmentId",
                table: "Clients",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AppointmentId",
                table: "Clients",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Appointments_AppointmentId",
                table: "Clients",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
