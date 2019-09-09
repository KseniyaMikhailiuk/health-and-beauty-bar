﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Umwa.DB;

namespace HealthAndBeauty.DB.Migrations
{
    [DbContext(typeof(HBContext))]
    [Migration("20190902132247_Add-additional-fields-to-service-and-center")]
    partial class Addadditionalfieldstoserviceandcenter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategotyID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.Center", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CenterID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CenterTypeId")
                        .HasColumnName("CenterTypeID");

                    b.Property<string>("MainImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CenterTypeId");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.CenterService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CenterServiceID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CenterId")
                        .HasColumnName("CenterID");

                    b.Property<double>("Discount");

                    b.Property<double>("Price");

                    b.Property<int>("ServiceId")
                        .HasColumnName("ServiceID");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("ServiceId");

                    b.ToTable("CenterServices");
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.CenterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CenterTypeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CenterTypes");
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ServiceID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("CategoryID");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.Center", b =>
                {
                    b.HasOne("HealthAndBeauty.DB.Entities.CenterType", "CenterType")
                        .WithMany("Centers")
                        .HasForeignKey("CenterTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.CenterService", b =>
                {
                    b.HasOne("HealthAndBeauty.DB.Entities.Center", "Center")
                        .WithMany("CenterServices")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthAndBeauty.DB.Entities.Service", "Service")
                        .WithMany("CenterServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.Service", b =>
                {
                    b.HasOne("HealthAndBeauty.DB.Entities.Category", "Category")
                        .WithMany("Services")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
