using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YungChingDemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    uuid = table.Column<long>(type: "INTEGER", maxLength: 5, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    ContactName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    ContactTitle = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Region = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 24, nullable: true),
                    Fax = table.Column<string>(type: "TEXT", maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.uuid);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    TitleOfCourtesy = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    HireDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Region = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    HomePhone = table.Column<string>(type: "TEXT", maxLength: 24, nullable: true),
                    Extension = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    Notes = table.Column<string>(type: "ntext", nullable: true),
                    ReportsTo = table.Column<int>(type: "INTEGER", nullable: true),
                    PhotoPath = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerID = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeID = table.Column<int>(type: "INTEGER", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RequiredDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ShippedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ShipVia = table.Column<int>(type: "INTEGER", nullable: true),
                    Freight = table.Column<decimal>(type: "money", nullable: false),
                    ShipName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    ShipAddress = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    ShipCity = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    ShipRegion = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    ShipPostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    ShipCountry = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
