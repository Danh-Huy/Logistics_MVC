using Logistics.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWeb.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1 , Title = "THỦ TỤC NHẬP KHẨU SON MÔI", SubTitle= "Các quy trình hải quan đối với các sản phẩm xuất khẩu gần đây đã có những thay đổi đáng kể", Content = "Các quy trình hải quan đối với các sản phẩm xuất khẩu gần đây đã có những thay đổi đáng kể", Author="Admin" },
                new Post { Id = 2 , Title = "HS CODE LÀ GÌ? QUY TẮC SỬ DỤNG VÀ CÁCH TRA MÃ HS CODE", SubTitle = "HS code là gì? HS code là loại mã được sử dụng rất nhiều trong ngành xuất nhập khẩu", Content = "HS code là gì? HS code là loại mã được sử dụng rất nhiều trong ngành xuất nhập khẩu", Author = "Admin" },
                new Post { Id = 3 , Title = "THỦ TỤC NHẬP KHẨU SON MÔI", SubTitle = "Bạn đang muốn nhập khẩu son môi để kinh doanh tại Việt Nam? Bạn đang tìm đơn vị logistics uy tín cung cấp dịch vụ nhập khẩu son môi về Việt Nam?", Content = "Bạn đang muốn nhập khẩu son môi để kinh doanh tại Việt Nam? Bạn đang tìm đơn vị logistics uy tín cung cấp dịch vụ nhập khẩu son môi về Việt Nam?", Author = "Admin" }
                );
        }
    }
}
