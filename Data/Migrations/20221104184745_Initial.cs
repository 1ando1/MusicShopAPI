using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExtraProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guitars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProductsId = table.Column<int>(type: "int", nullable: false),
                    ExtraProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guitars_ExtraProducts_ExtraProductId",
                        column: x => x.ExtraProductId,
                        principalTable: "ExtraProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ExtraProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Extra strings" },
                    { 2, "Pack of mediators (5 pieces)" },
                    { 3, "Pack of mediators (15 pieces)" },
                    { 4, "Extra strings + pack of mediators (5 pieces)" },
                    { 5, "Extra strings + pack of mediators (15 pieces)" },
                    { 6, "2 packs of extra strings" },
                    { 7, "5 packs of extra strings" },
                    { 8, "2 packs of extra strings + pack of mediators (5 pieces)" },
                    { 9, "2 packs of extra strings + pack of mediators (15 pieces)" },
                    { 10, "5 packs of extra strings + pack of mediators (5 pieces)" },
                    { 11, "5 packs of extra strings + pack of mediators (15 pieces)" }
                });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Color", "ExtraProductId", "ExtraProductsId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "White", null, 11, "https://www.muztorg.ru/files/1dd/71t/qsp/928/gsw/4cw/soo/88c/c/1dd71tqsp928gsw4cwsoo88cc.jpg", "Yamaha F310", 340f, "Western" },
                    { 2, "Black", null, 6, "https://www.muztorg.ru/files/1le/qe7/pgx/f6s/0s0/w40/og4/84s/w/1leqe7pgxf6s0s0w40og484sw.jpg", "Rockdale Aurora D1", 130f, "Dreadnought" },
                    { 3, "Brown", null, 8, "https://www.muztorg.ru/files/1rt/y8s/dbm/vhc/ks4/swg/4s4/o88/8/1rty8sdbmvhcks4swg4s4o888.jpeg", "Crafter D-7", 600f, "Dreadnought" },
                    { 4, "Natural", null, 2, "https://www.muztorg.ru/files/2rp/kok/xui/58g/gcw/04k/484/cg0/k/2rpkokxui58ggcw04k484cg0k.jpg", "Fender CD", 790f, "Dreadnought" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_ExtraProductId",
                table: "Guitars",
                column: "ExtraProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guitars");

            migrationBuilder.DropTable(
                name: "ExtraProducts");
        }
    }
}
