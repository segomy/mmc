using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace mmc.Data.Migrations
{
    public partial class ConsultasMovil1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsistenciaMiembros");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "ServiciosIglesia");

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MarcaDescripcion = table.Column<string>(type: "text", nullable: true),
                    UsuarioAlta = table.Column<string>(type: "text", nullable: true),
                    UsuarioModifica = table.Column<string>(type: "text", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaModifica = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Estado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    est_descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    est_est = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    est_fchalt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    est_usu_alt = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiciosIglesia",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    Horario = table.Column<int>(type: "integer", nullable: false),
                    Servicio = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiciosIglesia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Asunto = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaSolucion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Solucion = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: true),
                    Tecnico = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UsuarioAplicacionId = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsistenciaMiembros",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    MiembroFamilia = table.Column<string>(type: "text", nullable: false),
                    NumeroContacto = table.Column<int>(type: "integer", nullable: false),
                    horaid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistenciaMiembros", x => x.id);
                    table.ForeignKey(
                        name: "FK_AsistenciaMiembros_ServiciosIglesia_horaid",
                        column: x => x.horaid,
                        principalTable: "ServiciosIglesia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaMiembros_horaid",
                table: "AsistenciaMiembros",
                column: "horaid");
        }
    }
}
