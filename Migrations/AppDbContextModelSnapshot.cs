﻿// <auto-generated />
using System;
using EasyBank;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyBank.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyBank.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6fcb8921-fb46-4cd8-80d2-1acc8a521911"),
                            Email = "Arnold_Flatley58@yahoo.com",
                            FullName = "Arnold Flatley",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "987-516-5206 x20109",
                            Position = "Developer",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("f2552f83-e6bb-4996-8725-60d66ce89584"),
                            Email = "Jaime_Jacobs@gmail.com",
                            FullName = "Jaime Jacobs",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "1-756-926-3869 x81118",
                            Position = "cook",
                            Role = "Director"
                        },
                        new
                        {
                            Id = new Guid("d17dcae0-36b3-48f9-8860-829b5d0a0aa2"),
                            Email = "Eloise_Williamson20@gmail.com",
                            FullName = "Eloise Williamson",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "223.410.2681",
                            Position = "security",
                            Role = "Director"
                        },
                        new
                        {
                            Id = new Guid("82d02ca5-6ee5-4065-ad13-3e6827a5e2ad"),
                            Email = "Florence_Renner@gmail.com",
                            FullName = "Florence Renner",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "526-617-1119",
                            Position = "security",
                            Role = "Director"
                        },
                        new
                        {
                            Id = new Guid("6317f7ed-ec94-4ba0-bd23-4de7856c280b"),
                            Email = "Janie.Bruen@yahoo.com",
                            FullName = "Janie Bruen",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "851.303.5920 x286",
                            Position = "hr",
                            Role = "Employee"
                        },
                        new
                        {
                            Id = new Guid("6023b604-6f25-4f16-953a-683270e6c235"),
                            Email = "Carolyn12@hotmail.com",
                            FullName = "Carolyn Prohaska",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "(901) 488-1400 x67182",
                            Position = "developer",
                            Role = "Employee"
                        },
                        new
                        {
                            Id = new Guid("dd919828-f364-4ce6-88ed-912a77a486c5"),
                            Email = "Ida.Turner44@hotmail.com",
                            FullName = "Ida Turner",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "630.456.2494 x292",
                            Position = "developer",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("bcb4e691-44b3-4580-b62f-6be043ca0991"),
                            Email = "Naomi_Daugherty@yahoo.com",
                            FullName = "Naomi Daugherty",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "(498) 276-4247",
                            Position = "hr",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("753e74c5-e720-4492-a6a8-2d725701d970"),
                            Email = "Clara_Bashirian@yahoo.com",
                            FullName = "Clara Bashirian",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "1-932-758-9767",
                            Position = "developer",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("380c1add-b50e-459c-80b4-f176cacc7ac6"),
                            Email = "Nicholas_Treutel@yahoo.com",
                            FullName = "Nicholas Treutel",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "597.314.1906 x1024",
                            Position = "developer",
                            Role = "Employee"
                        },
                        new
                        {
                            Id = new Guid("4032d32c-f008-4d63-bb3c-1524d2a12c6a"),
                            Email = "Oliver_Dicki33@gmail.com",
                            FullName = "Oliver Dicki",
                            Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                            Phone = "731-794-9558 x164",
                            Position = "hr",
                            Role = "Director"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
