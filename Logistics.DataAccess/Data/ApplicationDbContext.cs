using Logistics.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWeb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1 , Title = "THỦ TỤC NHẬP KHẨU SON MÔI", Content = "Các quy trình hải quan đối với các sản phẩm xuất khẩu gần đây đã có những thay đổi đáng kể", Author="Admin" },
                new Post { Id = 2 , Title = "HS CODE LÀ GÌ? QUY TẮC SỬ DỤNG VÀ CÁCH TRA MÃ HS CODE", Content = "HS code là gì? HS code là loại mã được sử dụng rất nhiều trong ngành xuất nhập khẩu", Author = "Admin" },
                new Post { Id = 3 , Title = "THỦ TỤC NHẬP KHẨU SON MÔI", Content = "Bạn đang muốn nhập khẩu son môi để kinh doanh tại Việt Nam? Bạn đang tìm đơn vị logistics uy tín cung cấp dịch vụ nhập khẩu son môi về Việt Nam?", Author = "Admin" }
                );
        }
    }
}
