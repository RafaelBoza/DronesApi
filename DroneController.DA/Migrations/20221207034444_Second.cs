using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DroneController.DA.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loads_Drones_droneId",
                table: "Loads");

            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Loads_LoadId",
                table: "Medications");

            migrationBuilder.DropIndex(
                name: "IX_Medications_LoadId",
                table: "Medications");

            migrationBuilder.DropIndex(
                name: "IX_Loads_droneId",
                table: "Loads");

            migrationBuilder.DropColumn(
                name: "LoadId",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "droneId",
                table: "Loads");

            migrationBuilder.DropColumn(
                name: "drone_id",
                table: "Loads");

            migrationBuilder.AddColumn<Guid>(
                name: "Drone",
                table: "Loads",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LoadDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Medication = table.Column<Guid>(nullable: true),
                    Load = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadDetails_Loads_Load",
                        column: x => x.Load,
                        principalTable: "Loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoadDetails_Medications_Medication",
                        column: x => x.Medication,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loads_Drone",
                table: "Loads",
                column: "Drone");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDetails_Load",
                table: "LoadDetails",
                column: "Load");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDetails_Medication",
                table: "LoadDetails",
                column: "Medication");

            migrationBuilder.AddForeignKey(
                name: "FK_Loads_Drones_Drone",
                table: "Loads",
                column: "Drone",
                principalTable: "Drones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loads_Drones_Drone",
                table: "Loads");

            migrationBuilder.DropTable(
                name: "LoadDetails");

            migrationBuilder.DropIndex(
                name: "IX_Loads_Drone",
                table: "Loads");

            migrationBuilder.DropColumn(
                name: "Drone",
                table: "Loads");

            migrationBuilder.AddColumn<Guid>(
                name: "LoadId",
                table: "Medications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "droneId",
                table: "Loads",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "drone_id",
                table: "Loads",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Medications_LoadId",
                table: "Medications",
                column: "LoadId");

            migrationBuilder.CreateIndex(
                name: "IX_Loads_droneId",
                table: "Loads",
                column: "droneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loads_Drones_droneId",
                table: "Loads",
                column: "droneId",
                principalTable: "Drones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Loads_LoadId",
                table: "Medications",
                column: "LoadId",
                principalTable: "Loads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
