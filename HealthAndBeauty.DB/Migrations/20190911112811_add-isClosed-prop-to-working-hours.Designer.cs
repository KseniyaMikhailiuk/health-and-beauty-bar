﻿// <auto-generated />
using System;
using HealthAndBeauty.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthAndBeauty.DB.Migrations
{
    [DbContext(typeof(HBContext))]
    [Migration("20190911112811_add-isClosed-prop-to-working-hours")]
    partial class addisClosedproptoworkinghours
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CategoryA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CategoryB"
                        },
                        new
                        {
                            Id = 3,
                            Name = "CategoryC"
                        },
                        new
                        {
                            Id = 4,
                            Name = "CategoryD"
                        },
                        new
                        {
                            Id = 5,
                            Name = "CategoryE"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CenterTypeId = 1,
                            MainImageUrl = "https://picsum.photos/id/237/200/300",
                            Name = "CenterA"
                        },
                        new
                        {
                            Id = 2,
                            CenterTypeId = 1,
                            MainImageUrl = "https://picsum.photos/id/237/200/300",
                            Name = "CenterB"
                        },
                        new
                        {
                            Id = 3,
                            CenterTypeId = 2,
                            MainImageUrl = "https://picsum.photos/id/237/200/300",
                            Name = "CenterC"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CenterId = 1,
                            Discount = 0.0,
                            Price = 110.0,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 2,
                            CenterId = 1,
                            Discount = 0.0,
                            Price = 120.0,
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 3,
                            CenterId = 1,
                            Discount = 0.0,
                            Price = 1120.0,
                            ServiceId = 9
                        },
                        new
                        {
                            Id = 4,
                            CenterId = 1,
                            Discount = 0.0,
                            Price = 104.0,
                            ServiceId = 12
                        },
                        new
                        {
                            Id = 5,
                            CenterId = 1,
                            Discount = 0.0,
                            Price = 1001.0,
                            ServiceId = 10
                        },
                        new
                        {
                            Id = 6,
                            CenterId = 2,
                            Discount = 0.0,
                            Price = 11230.0,
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 7,
                            CenterId = 2,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 8,
                            CenterId = 2,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 9,
                            CenterId = 2,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 7
                        },
                        new
                        {
                            Id = 10,
                            CenterId = 2,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 12
                        },
                        new
                        {
                            Id = 11,
                            CenterId = 2,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 12,
                            CenterId = 2,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 13,
                            CenterId = 3,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 8
                        },
                        new
                        {
                            Id = 14,
                            CenterId = 3,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 15,
                            CenterId = 3,
                            Discount = 0.0,
                            Price = 100.0,
                            ServiceId = 5
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Medical"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "ServiceA"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "ServiceB"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Name = "ServiceC"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "ServiceD"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "ServiceE"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Name = "ServiceF"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Name = "ServiceG"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            Name = "ServiceH"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            Name = "ServiceI"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Name = "ServiceJ"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Name = "ServiceK"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Name = "ServiceL"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Name = "ServiceM"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 4,
                            Name = "ServiceN"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Name = "ServiceO"
                        });
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("GenderId");

                    b.Property<string>("LastName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Salt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.WorkingHours", b =>
                {
                    b.Property<int>("CenterId")
                        .HasColumnName("CenterID");

                    b.Property<int>("WeekDayId")
                        .HasColumnName("WeekDayID");

                    b.Property<TimeSpan>("EndTime");

                    b.Property<bool>("IsClosed");

                    b.Property<TimeSpan>("StartTime");

                    b.HasKey("CenterId", "WeekDayId");

                    b.ToTable("WorkingHours");
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

            modelBuilder.Entity("HealthAndBeauty.DB.Entities.WorkingHours", b =>
                {
                    b.HasOne("HealthAndBeauty.DB.Entities.Center", "Center")
                        .WithMany("WorkingHours")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}