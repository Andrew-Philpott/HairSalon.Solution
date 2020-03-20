using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HairSalon.Migrations
{
    public partial class FixAppointmentClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Clients_ClientId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Stylists_StylistId",
                table: "Appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_ClientId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_StylistId",
                table: "Appointments",
                newName: "IX_Appointments_StylistId");

            migrationBuilder.AddColumn<Guid>(
                name: "AppointmentId",
                table: "Clients",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AppointmentId",
                table: "Clients",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Stylists_StylistId",
                table: "Appointments",
                column: "StylistId",
                principalTable: "Stylists",
                principalColumn: "StylistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Appointments_AppointmentId",
                table: "Clients",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Stylists_StylistId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Appointments_AppointmentId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AppointmentId",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_StylistId",
                table: "Appointment",
                newName: "IX_Appointment_StylistId");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Appointment",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ClientId",
                table: "Appointment",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Clients_ClientId",
                table: "Appointment",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Stylists_StylistId",
                table: "Appointment",
                column: "StylistId",
                principalTable: "Stylists",
                principalColumn: "StylistId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
