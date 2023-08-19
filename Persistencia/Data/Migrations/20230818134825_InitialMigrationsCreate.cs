using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationsCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Automovil",
                columns: table => new
                {
                    ID_Automovil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capasidad = table.Column<int>(type: "int", nullable: false),
                    Precio_decimal = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automovil", x => x.ID_Automovil);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID_Cliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    ID_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.ID_Empleado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    ID_Sucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.ID_Sucursal);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    ID_Alquiler = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime", nullable: false),
                    Costo_Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.ID_Alquiler);
                    table.ForeignKey(
                        name: "FK_Alquiler_Automovil_ID_Automovil",
                        column: x => x.ID_Automovil,
                        principalTable: "Automovil",
                        principalColumn: "ID_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Cliente_ID_Cliente",
                        column: x => x.ID_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ID_Reserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Automovil = table.Column<int>(type: "int", nullable: false),
                    Fecha_Reserva = table.Column<DateTime>(type: "datetime", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime", nullable: false),
                    EStado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.ID_Reserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Automovil_ID_Automovil",
                        column: x => x.ID_Automovil,
                        principalTable: "Automovil",
                        principalColumn: "ID_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente_ID_Cliente",
                        column: x => x.ID_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sucursal_automovil",
                columns: table => new
                {
                    ID_Sucursal = table.Column<int>(type: "int", nullable: false),
                    ID_Automovil = table.Column<int>(type: "int", nullable: false),
                    Cantidad_Disponible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal_automovil", x => new { x.ID_Sucursal, x.ID_Automovil });
                    table.ForeignKey(
                        name: "FK_Sucursal_automovil_Automovil_ID_Automovil",
                        column: x => x.ID_Automovil,
                        principalTable: "Automovil",
                        principalColumn: "ID_Automovil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sucursal_automovil_Sucursal_ID_Sucursal",
                        column: x => x.ID_Sucursal,
                        principalTable: "Sucursal",
                        principalColumn: "ID_Sucursal",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Registro_devolucion",
                columns: table => new
                {
                    ID_Registro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Alquiler = table.Column<int>(type: "int", nullable: false),
                    ID_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Devolucion = table.Column<DateTime>(type: "datetime", nullable: false),
                    Combustible_Devuelto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Kilometraje_Devuelto = table.Column<int>(type: "int", nullable: false),
                    Monto_Adicional = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro_devolucion", x => x.ID_Registro);
                    table.ForeignKey(
                        name: "FK_Registro_devolucion_Alquiler_ID_Alquiler",
                        column: x => x.ID_Alquiler,
                        principalTable: "Alquiler",
                        principalColumn: "ID_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registro_devolucion_Empleado_ID_Empleado",
                        column: x => x.ID_Empleado,
                        principalTable: "Empleado",
                        principalColumn: "ID_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Registro_entrega",
                columns: table => new
                {
                    ID_Registro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_Alquiler = table.Column<int>(type: "int", nullable: false),
                    ID_Empleado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Entrega = table.Column<DateTime>(type: "datetime", nullable: false),
                    Combustible_Entregado = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Kilometraje_Entregado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro_entrega", x => x.ID_Registro);
                    table.ForeignKey(
                        name: "FK_Registro_entrega_Alquiler_ID_Alquiler",
                        column: x => x.ID_Alquiler,
                        principalTable: "Alquiler",
                        principalColumn: "ID_Alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registro_entrega_Empleado_ID_Empleado",
                        column: x => x.ID_Empleado,
                        principalTable: "Empleado",
                        principalColumn: "ID_Empleado",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_ID_Automovil",
                table: "Alquiler",
                column: "ID_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_ID_Cliente",
                table: "Alquiler",
                column: "ID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_devolucion_ID_Alquiler",
                table: "Registro_devolucion",
                column: "ID_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_devolucion_ID_Empleado",
                table: "Registro_devolucion",
                column: "ID_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_entrega_ID_Alquiler",
                table: "Registro_entrega",
                column: "ID_Alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_entrega_ID_Empleado",
                table: "Registro_entrega",
                column: "ID_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ID_Automovil",
                table: "Reserva",
                column: "ID_Automovil");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ID_Cliente",
                table: "Reserva",
                column: "ID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_automovil_ID_Automovil",
                table: "Sucursal_automovil",
                column: "ID_Automovil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro_devolucion");

            migrationBuilder.DropTable(
                name: "Registro_entrega");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Sucursal_automovil");

            migrationBuilder.DropTable(
                name: "Alquiler");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Sucursal");

            migrationBuilder.DropTable(
                name: "Automovil");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
