using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace anket.Migrations
{
    
    public partial class IlkKurulum : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Katilimcilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fakulte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bolum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplulukUyeligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KatilimGunu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KalkisNoktasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QrKodOlusturulduMu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Katilimcilar", x => x.Id);
                });
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Katilimcilar");
        }
    }
}
