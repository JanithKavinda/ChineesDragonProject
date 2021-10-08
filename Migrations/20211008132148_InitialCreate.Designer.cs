﻿// <auto-generated />
using Asp.netCoreChineesDragon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.netCoreChineesDragon.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20211008132148_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.netCoreChineesDragon.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderDateTime")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 48)))
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrderItems")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OrderStatuses")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("OrderedThrough")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ReferanceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
