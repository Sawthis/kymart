﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using artbackend.Database;

namespace artbackend.Migrations
{
    [DbContext(typeof(LikesContext))]
    partial class LikesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("artbackend.Database.Like", b =>
                {
                    b.Property<string>("ImageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageVersion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId", "ImageVersion");

                    b.ToTable("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
