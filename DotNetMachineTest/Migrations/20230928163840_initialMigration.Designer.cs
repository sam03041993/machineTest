﻿// <auto-generated />
using DotNetMachineTest.Models.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetMachineTest.Migrations
{
    [DbContext(typeof(MachineTestContext))]
    [Migration("20230928163840_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetMachineTest.Models.ConversionRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FromUnitId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("ToUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ConversionRate");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FromUnitId = 1,
                            Rate = 1.8,
                            ToUnitId = 2
                        },
                        new
                        {
                            Id = 2,
                            FromUnitId = 2,
                            Rate = 0.55556000000000005,
                            ToUnitId = 1
                        },
                        new
                        {
                            Id = 3,
                            FromUnitId = 3,
                            Rate = 3.28084,
                            ToUnitId = 4
                        },
                        new
                        {
                            Id = 4,
                            FromUnitId = 4,
                            Rate = 0.30399999999999999,
                            ToUnitId = 5
                        });
                });

            modelBuilder.Entity("DotNetMachineTest.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Unit");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Celsius"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fahrenheit"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Meter"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Feet"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
