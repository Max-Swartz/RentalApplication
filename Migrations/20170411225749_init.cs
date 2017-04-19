using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentalApplicationAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    FName1 = table.Column<string>(nullable: true),
                    FName2 = table.Column<string>(nullable: true),
                    LName1 = table.Column<string>(nullable: true),
                    LName2 = table.Column<string>(nullable: true),
                    PropertyID = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AddtlComments = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    LeaseDuration = table.Column<string>(nullable: true),
                    ListDate = table.Column<DateTime>(nullable: false),
                    NumBaths = table.Column<int>(nullable: false),
                    NumbBeds = table.Column<int>(nullable: false),
                    RentAmt = table.Column<decimal>(nullable: false),
                    SqaureFootage = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AddtlComments = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ListDate = table.Column<DateTime>(nullable: false),
                    NumBaths = table.Column<int>(nullable: false),
                    NumbBeds = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    SqaureFootage = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
