using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectWarehouse.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnits",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnits", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemUnitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Items_ItemUnits_ItemUnitID",
                        column: x => x.ItemUnitID,
                        principalTable: "ItemUnits",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyPermits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WID = table.Column<int>(type: "int", nullable: false),
                    SID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyPermits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplyPermits_Suppliers_SID",
                        column: x => x.SID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyPermits_Warehouses_WID",
                        column: x => x.WID,
                        principalTable: "Warehouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromW = table.Column<int>(type: "int", nullable: false),
                    ToW = table.Column<int>(type: "int", nullable: false),
                    SID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transfers_Suppliers_SID",
                        column: x => x.SID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transfers_Warehouses_FromW",
                        column: x => x.FromW,
                        principalTable: "Warehouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transfers_Warehouses_ToW",
                        column: x => x.ToW,
                        principalTable: "Warehouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawPermits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WID = table.Column<int>(type: "int", nullable: false),
                    CID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawPermits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WithdrawPermits_Clients_CID",
                        column: x => x.CID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WithdrawPermits_Warehouses_WID",
                        column: x => x.WID,
                        principalTable: "Warehouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyPermitItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SPID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyPermitItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplyPermitItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyPermitItems_SupplyPermits_SPID",
                        column: x => x.SPID,
                        principalTable: "SupplyPermits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferID = table.Column<int>(type: "int", nullable: false),
                    IID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransferItems_Items_IID",
                        column: x => x.IID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferItems_Transfers_TransferID",
                        column: x => x.TransferID,
                        principalTable: "Transfers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawPermitItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WPID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawPermitItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WithdrawPermitItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WithdrawPermitItems_WithdrawPermits_WPID",
                        column: x => x.WPID,
                        principalTable: "WithdrawPermits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemUnitID",
                table: "Items",
                column: "ItemUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermitItems_ItemID",
                table: "SupplyPermitItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermitItems_SPID",
                table: "SupplyPermitItems",
                column: "SPID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermits_SID",
                table: "SupplyPermits",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyPermits_WID",
                table: "SupplyPermits",
                column: "WID");

            migrationBuilder.CreateIndex(
                name: "IX_TransferItems_IID",
                table: "TransferItems",
                column: "IID");

            migrationBuilder.CreateIndex(
                name: "IX_TransferItems_TransferID",
                table: "TransferItems",
                column: "TransferID");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_FromW",
                table: "Transfers",
                column: "FromW");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_SID",
                table: "Transfers",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_ToW",
                table: "Transfers",
                column: "ToW");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawPermitItems_ItemID",
                table: "WithdrawPermitItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawPermitItems_WPID",
                table: "WithdrawPermitItems",
                column: "WPID");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawPermits_CID",
                table: "WithdrawPermits",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawPermits_WID",
                table: "WithdrawPermits",
                column: "WID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplyPermitItems");

            migrationBuilder.DropTable(
                name: "TransferItems");

            migrationBuilder.DropTable(
                name: "WithdrawPermitItems");

            migrationBuilder.DropTable(
                name: "SupplyPermits");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "WithdrawPermits");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "ItemUnits");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
