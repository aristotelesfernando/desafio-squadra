using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class incluindo_campo_accepted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gerenciamento_Leads",
                keyColumn: "Id",
                keyValue: new Guid("2c0b47c5-f2ff-4aa2-9987-b21fbc63060a"));

            migrationBuilder.DeleteData(
                table: "Gerenciamento_Leads",
                keyColumn: "Id",
                keyValue: new Guid("c4fc386c-b035-4d11-a529-a3756e79073d"));

            migrationBuilder.DeleteData(
                table: "Gerenciamento_Leads",
                keyColumn: "Id",
                keyValue: new Guid("e0ca63af-ea15-4e22-bbc7-9379ad4917e9"));

            migrationBuilder.AddColumn<string>(
                name: "Accepted",
                table: "Gerenciamento_Leads",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "A");

            migrationBuilder.InsertData(
                table: "Gerenciamento_Leads",
                columns: new[] { "Id", "Accepted", "Category", "Contact_Email", "Contact_First_Name", "Contact_Full_Name", "Contact_Phone_Number", "Date_Created", "Description", "Price", "Suburb" },
                values: new object[] { new Guid("1b409c92-e2cc-450e-a4d5-7088e7a105e7"), "A", "Seriço doméstico", "joao@hotmail.com", "João", "João da Silva", "55-21-988776655", new DateTime(2022, 11, 3, 2, 33, 17, 301, DateTimeKind.Utc).AddTicks(6079), "Descrição xxxxxxxxxxxxxxxxxx", 20m, "Não sei" });

            migrationBuilder.InsertData(
                table: "Gerenciamento_Leads",
                columns: new[] { "Id", "Accepted", "Category", "Contact_Email", "Contact_First_Name", "Contact_Full_Name", "Contact_Phone_Number", "Date_Created", "Description", "Price", "Suburb" },
                values: new object[] { new Guid("8d98436d-53b5-4a82-9a0a-fed3a769e766"), "A", "Diarista", "anaoliveira@gmail.com", "Ana Maria", "Ana Maria Oliveira", "55-91-987785544", new DateTime(2022, 11, 3, 2, 33, 17, 301, DateTimeKind.Utc).AddTicks(6085), "Descrição xxxxxxxxxxxxxxxxxx", 50m, "Não sei" });

            migrationBuilder.InsertData(
                table: "Gerenciamento_Leads",
                columns: new[] { "Id", "Accepted", "Category", "Contact_Email", "Contact_First_Name", "Contact_Full_Name", "Contact_Phone_Number", "Date_Created", "Description", "Price", "Suburb" },
                values: new object[] { new Guid("e9a0d685-300d-4626-94d1-74ea56e59c05"), "A", "Pintura", "cbarbosa@icloud.com", "Carlos", "Carlos Barbosa", "55-98-987660011", new DateTime(2022, 11, 3, 2, 33, 17, 301, DateTimeKind.Utc).AddTicks(6083), "Descrição xxxxxxxxxxxxxxxxxx", 100m, "Não sei" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gerenciamento_Leads",
                keyColumn: "Id",
                keyValue: new Guid("1b409c92-e2cc-450e-a4d5-7088e7a105e7"));

            migrationBuilder.DeleteData(
                table: "Gerenciamento_Leads",
                keyColumn: "Id",
                keyValue: new Guid("8d98436d-53b5-4a82-9a0a-fed3a769e766"));

            migrationBuilder.DeleteData(
                table: "Gerenciamento_Leads",
                keyColumn: "Id",
                keyValue: new Guid("e9a0d685-300d-4626-94d1-74ea56e59c05"));

            migrationBuilder.DropColumn(
                name: "Accepted",
                table: "Gerenciamento_Leads");

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
    }
}
