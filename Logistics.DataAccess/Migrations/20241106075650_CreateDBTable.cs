using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Logistics.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateDBTable : Migration
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
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Content", "SubTitle", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", "Các quy trình hải quan đối với các sản phẩm xuất khẩu gần đây đã có những thay đổi đáng kể", "Các quy trình hải quan đối với các sản phẩm xuất khẩu gần đây đã có những thay đổi đáng kể", "THỦ TỤC NHẬP KHẨU SON MÔI" },
                    { 2, "Admin", "HS code là gì? HS code là loại mã được sử dụng rất nhiều trong ngành xuất nhập khẩu", "HS code là gì? HS code là loại mã được sử dụng rất nhiều trong ngành xuất nhập khẩu", "HS CODE LÀ GÌ? QUY TẮC SỬ DỤNG VÀ CÁCH TRA MÃ HS CODE" },
                    { 3, "Admin", "Bạn đang muốn nhập khẩu son môi để kinh doanh tại Việt Nam? Bạn đang tìm đơn vị logistics uy tín cung cấp dịch vụ nhập khẩu son môi về Việt Nam?", "Bạn đang muốn nhập khẩu son môi để kinh doanh tại Việt Nam? Bạn đang tìm đơn vị logistics uy tín cung cấp dịch vụ nhập khẩu son môi về Việt Nam?", "THỦ TỤC NHẬP KHẨU SON MÔI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
