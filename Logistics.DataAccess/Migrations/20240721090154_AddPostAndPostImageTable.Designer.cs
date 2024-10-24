﻿// <auto-generated />
using LogisticsWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Logistics.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240721090154_AddPostAndPostImageTable")]
    partial class AddPostAndPostImageTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Logistics.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Admin",
                            Content = "Các quy trình hải quan đối với các sản phẩm xuất khẩu gần đây đã có những thay đổi đáng kể",
                            Title = "THỦ TỤC NHẬP KHẨU SON MÔI"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Admin",
                            Content = "HS code là gì? HS code là loại mã được sử dụng rất nhiều trong ngành xuất nhập khẩu",
                            Title = "HS CODE LÀ GÌ? QUY TẮC SỬ DỤNG VÀ CÁCH TRA MÃ HS CODE"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Admin",
                            Content = "Bạn đang muốn nhập khẩu son môi để kinh doanh tại Việt Nam? Bạn đang tìm đơn vị logistics uy tín cung cấp dịch vụ nhập khẩu son môi về Việt Nam?",
                            Title = "THỦ TỤC NHẬP KHẨU SON MÔI"
                        });
                });

            modelBuilder.Entity("Logistics.Models.PostImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostImage");
                });

            modelBuilder.Entity("Logistics.Models.PostImage", b =>
                {
                    b.HasOne("Logistics.Models.Post", "Post")
                        .WithMany("PostImages")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Logistics.Models.Post", b =>
                {
                    b.Navigation("PostImages");
                });
#pragma warning restore 612, 618
        }
    }
}