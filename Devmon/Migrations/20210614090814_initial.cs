using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Devmon.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ms02",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    lokasi = table.Column<string>(type: "text", nullable: true),
                    waktu = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    controller = table.Column<string>(type: "text", nullable: true),
                    mac = table.Column<string>(type: "text", nullable: true),
                    ip = table.Column<string>(type: "text", nullable: true),
                    sensorsuhu_in = table.Column<decimal>(type: "numeric", nullable: false),
                    sensorsuhu_out = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms02", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ms04",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    lokasi = table.Column<string>(type: "text", nullable: true),
                    waktu = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    controller = table.Column<string>(type: "text", nullable: true),
                    mac = table.Column<string>(type: "text", nullable: true),
                    ip = table.Column<string>(type: "text", nullable: true),
                    sensorsuhu_in = table.Column<decimal>(type: "numeric", nullable: false),
                    sensorsuhu_out = table.Column<decimal>(type: "numeric", nullable: false),
                    voltage_ac = table.Column<decimal>(type: "numeric", nullable: false),
                    voltage_dc = table.Column<decimal>(type: "numeric", nullable: false),
                    ampere_ac = table.Column<decimal>(type: "numeric", nullable: false),
                    ampere_dc = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms04", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ms06",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    lokasi = table.Column<string>(type: "text", nullable: true),
                    waktu = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    controller = table.Column<string>(type: "text", nullable: true),
                    mac = table.Column<string>(type: "text", nullable: true),
                    ip = table.Column<string>(type: "text", nullable: true),
                    voltage_ac = table.Column<decimal>(type: "numeric", nullable: false),
                    voltage_ac_2 = table.Column<decimal>(type: "numeric", nullable: false),
                    voltage_dc = table.Column<decimal>(type: "numeric", nullable: false),
                    voltage_dc_2 = table.Column<decimal>(type: "numeric", nullable: false),
                    ampere_ac = table.Column<decimal>(type: "numeric", nullable: false),
                    ampere_ac_2 = table.Column<decimal>(type: "numeric", nullable: false),
                    ampere_dc = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms06", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ms02");

            migrationBuilder.DropTable(
                name: "ms04");

            migrationBuilder.DropTable(
                name: "ms06");
        }
    }
}
