using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Migrations
{
    public partial class InitialMigrationa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_carrerasTotalesUnis",
                columns: table => new
                {
                    IdCarrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCarrera = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodigoCarrera = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__carrerasTotalesUnis", x => x.IdCarrera);
                });

            migrationBuilder.CreateTable(
                name: "_materiasTotalesUni",
                columns: table => new
                {
                    IdMaterias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombresMaterias = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__materiasTotalesUni", x => x.IdMaterias);
                });

            migrationBuilder.CreateTable(
                name: "_usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cuatrimestre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_carreraEstudiante",
                columns: table => new
                {
                    IdCarrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCarrera = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodigoCarrera = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__carreraEstudiante", x => x.IdCarrera);
                    table.ForeignKey(
                        name: "FK__carreraEstudiante__usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "_usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_materiasEstudiante",
                columns: table => new
                {
                    IdMaterias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombresMaterias = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__materiasEstudiante", x => x.IdMaterias);
                    table.ForeignKey(
                        name: "FK__materiasEstudiante__usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "_usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX__carreraEstudiante_UsuariosId",
                table: "_carreraEstudiante",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX__materiasEstudiante_UsuariosId",
                table: "_materiasEstudiante",
                column: "UsuariosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_carreraEstudiante");

            migrationBuilder.DropTable(
                name: "_carrerasTotalesUnis");

            migrationBuilder.DropTable(
                name: "_materiasEstudiante");

            migrationBuilder.DropTable(
                name: "_materiasTotalesUni");

            migrationBuilder.DropTable(
                name: "_usuarios");
        }
    }
}
