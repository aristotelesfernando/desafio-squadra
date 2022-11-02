using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gerenciamento_Leads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Contact_First_Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Contact_Full_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Contact_Phone_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Contact_Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerenciamento_Leads", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Gerenciamento_Leads",
                columns: new[] { "Id", "Category", "Contact_Email", "Contact_First_Name", "Contact_Full_Name", "Contact_Phone_Number", "Date_Created", "Description", "Price", "Suburb" },
                values: new object[] { new Guid("2c0b47c5-f2ff-4aa2-9987-b21fbc63060a"), "Seriço doméstico", "joao@hotmail.com", "João", "João da Silva", "55-21-988776655", new DateTime(2022, 11, 2, 22, 54, 51, 585, DateTimeKind.Utc).AddTicks(4487), "Descrição xxxxxxxxxxxxxxxxxx", 20m, "Não sei" });

            migrationBuilder.InsertData(
                table: "Gerenciamento_Leads",
                columns: new[] { "Id", "Category", "Contact_Email", "Contact_First_Name", "Contact_Full_Name", "Contact_Phone_Number", "Date_Created", "Description", "Price", "Suburb" },
                values: new object[] { new Guid("c4fc386c-b035-4d11-a529-a3756e79073d"), "Pintura", "cbarbosa@icloud.com", "Carlos", "Carlos Barbosa", "55-98-987660011", new DateTime(2022, 11, 2, 22, 54, 51, 585, DateTimeKind.Utc).AddTicks(4495), "Descrição xxxxxxxxxxxxxxxxxx", 100m, "Não sei" });

            migrationBuilder.InsertData(
                table: "Gerenciamento_Leads",
                columns: new[] { "Id", "Category", "Contact_Email", "Contact_First_Name", "Contact_Full_Name", "Contact_Phone_Number", "Date_Created", "Description", "Price", "Suburb" },
                values: new object[] { new Guid("e0ca63af-ea15-4e22-bbc7-9379ad4917e9"), "Diarista", "anaoliveira@gmail.com", "Ana Maria", "Ana Maria Oliveira", "55-91-987785544", new DateTime(2022, 11, 2, 22, 54, 51, 585, DateTimeKind.Utc).AddTicks(4497), "Descrição xxxxxxxxxxxxxxxxxx", 50m, "Não sei" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gerenciamento_Leads");
        }
    }
}
