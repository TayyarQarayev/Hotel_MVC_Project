﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete.EntityFrameworkCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations;

[DbContext(typeof(HotelEcommerceContext))]
partial class HotelEcommerceContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.22")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

        modelBuilder.Entity("Entity.Concrete.Customers.Customers", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                b.Property<string>("ContactNO")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("DateOfBirth")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("Customers");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.HotelServices", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                b.Property<string>("HotelServicesName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("HotelServices");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Reservations", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                b.Property<int>("CustomerID")
                    .HasColumnType("int");

                b.Property<DateTime>("ReservationDate")
                    .HasColumnType("datetime2");

                b.Property<int>("ReservationNumber")
                    .HasColumnType("int");

                b.HasKey("ID");

                b.HasIndex("CustomerID");

                b.ToTable("Reservations");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Rooms", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                b.Property<int>("ChilderenCount")
                    .HasColumnType("int");

                b.Property<int>("GuestsCount")
                    .HasColumnType("int");

                b.Property<int>("ReservationID")
                    .HasColumnType("int");

                b.Property<int>("RoomNumber")
                    .HasColumnType("int");

                b.Property<int>("RoomPrice")
                    .HasColumnType("int");

                b.Property<decimal>("RoomSize")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("RoomTypeID")
                    .HasColumnType("int");

                b.HasKey("ID");

                b.HasIndex("ReservationID");

                b.HasIndex("RoomTypeID");

                b.ToTable("Rooms");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Rooms_Services", b =>
            {
                b.Property<int>("ServiceID")
                    .HasColumnType("int");

                b.Property<int>("RoomID")
                    .HasColumnType("int");

                b.HasKey("ServiceID", "RoomID");

                b.HasIndex("RoomID");

                b.ToTable("Rooms_Services");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.RoomServices", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                b.Property<string>("RoomServicesName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("RoomServices");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.RoomType", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                b.Property<string>("TypeName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("RoomType");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Services", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                b.Property<int>("HotelServiceID")
                    .HasColumnType("int");

                b.Property<int>("RoomServiceID")
                    .HasColumnType("int");

                b.HasKey("ID");

                b.HasIndex("HotelServiceID");

                b.HasIndex("RoomServiceID");

                b.ToTable("Services");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Reservations", b =>
            {
                b.HasOne("Entity.Concrete.Customers.Customers", "Customers")
                    .WithMany("Reservations")
                    .HasForeignKey("CustomerID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Customers");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Rooms", b =>
            {
                b.HasOne("Entity.Concrete.Customers.Reservations", "Reservations")
                    .WithMany("Rooms")
                    .HasForeignKey("ReservationID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Entity.Concrete.Customers.RoomType", "RoomType")
                    .WithMany("Rooms")
                    .HasForeignKey("RoomTypeID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Reservations");

                b.Navigation("RoomType");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Rooms_Services", b =>
            {
                b.HasOne("Entity.Concrete.Customers.Rooms", "Rooms")
                    .WithMany("Rooms_Services")
                    .HasForeignKey("RoomID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Entity.Concrete.Customers.Services", "Services")
                    .WithMany("Rooms_Services")
                    .HasForeignKey("ServiceID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Rooms");

                b.Navigation("Services");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Services", b =>
            {
                b.HasOne("Entity.Concrete.Customers.HotelServices", "HotelServices")
                    .WithMany("Services")
                    .HasForeignKey("HotelServiceID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Entity.Concrete.Customers.RoomServices", "RoomServices")
                    .WithMany("Services")
                    .HasForeignKey("RoomServiceID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("HotelServices");

                b.Navigation("RoomServices");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Customers", b =>
            {
                b.Navigation("Reservations");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.HotelServices", b =>
            {
                b.Navigation("Services");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Reservations", b =>
            {
                b.Navigation("Rooms");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Rooms", b =>
            {
                b.Navigation("Rooms_Services");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.RoomServices", b =>
            {
                b.Navigation("Services");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.RoomType", b =>
            {
                b.Navigation("Rooms");
            });

        modelBuilder.Entity("Entity.Concrete.Customers.Services", b =>
            {
                b.Navigation("Rooms_Services");
            });
#pragma warning restore 612, 618
    }
}
