using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticaParcial2.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    cedulaIdentidad = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.cedulaIdentidad);
                });

            migrationBuilder.CreateTable(
                name: "tipos",
                columns: table => new
                {
                    idTipoProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos", x => x.idTipoProducto);
                });

            migrationBuilder.CreateTable(
                name: "carritos",
                columns: table => new
                {
                    idCarrito = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    codigoBarra = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    cedulaIdentidad = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carritos", x => x.idCarrito);
                    table.ForeignKey(
                        name: "FK_carritos_personas_cedulaIdentidad",
                        column: x => x.cedulaIdentidad,
                        principalTable: "personas",
                        principalColumn: "cedulaIdentidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    codigoBarra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idTipoProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.codigoBarra);
                    table.ForeignKey(
                        name: "FK_productos_carritos_codigoBarra",
                        column: x => x.codigoBarra,
                        principalTable: "carritos",
                        principalColumn: "idCarrito",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productos_tipos_codigoBarra",
                        column: x => x.codigoBarra,
                        principalTable: "tipos",
                        principalColumn: "idTipoProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carritos_cedulaIdentidad",
                table: "carritos",
                column: "cedulaIdentidad",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "carritos");

            migrationBuilder.DropTable(
                name: "tipos");

            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
