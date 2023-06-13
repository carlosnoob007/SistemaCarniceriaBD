using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaCarniceriaBD.Migrations
{
    /// <inheritdoc />
    public partial class migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    apellidoUsuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    cedulaUsuario = table.Column<string>(type: "varchar(20)", nullable: false),
                    rol = table.Column<string>(type: "varchar(20)", nullable: false),
                    usuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    clave = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    contraseña = table.Column<string>(type: "varchar(50)", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.id);
                    table.ForeignKey(
                        name: "FK_Login_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Login_UsuariosId",
                table: "Login",
                column: "UsuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
