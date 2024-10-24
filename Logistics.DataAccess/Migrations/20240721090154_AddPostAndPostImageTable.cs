using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Logistics.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPostAndPostImageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImage_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", "Các quy trình hải quan đối với các sản phẩm xuất khẩu gần đây đã có những thay đổi đáng kể", "THỦ TỤC NHẬP KHẨU SON MÔI" },
                    { 2, "Admin", "HS code là gì? HS code là loại mã được sử dụng rất nhiều trong ngành xuất nhập khẩu", "HS CODE LÀ GÌ? QUY TẮC SỬ DỤNG VÀ CÁCH TRA MÃ HS CODE" },
                    { 3, "Admin", "Bạn đang muốn nhập khẩu son môi để kinh doanh tại Việt Nam? Bạn đang tìm đơn vị logistics uy tín cung cấp dịch vụ nhập khẩu son môi về Việt Nam?", "THỦ TỤC NHẬP KHẨU SON MÔI" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostImage");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
