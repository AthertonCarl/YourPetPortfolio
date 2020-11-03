﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YourPetPortfolio.Models;

namespace YourPetPortfolio.Migrations
{
    [DbContext(typeof(AnimalRescueContext))]
    [Migration("20201009200954_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YourPetPortfolio.Models.Animals", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalAge")
                        .HasColumnType("int");

                    b.Property<string>("AnimalBreed")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalGender")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("AnimalTemporment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId")
                        .HasName("PK__Animals__A21A7307B78DEB17");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("YourPetPortfolio.Models.Employees", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("VolunteerId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId")
                        .HasName("PK__Employee__7AD04F11A6431903");

                    b.HasIndex("AnimalId");

                    b.HasIndex("VolunteerId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("YourPetPortfolio.Models.Volunteers", b =>
                {
                    b.Property<int>("VolunteerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("VolunteerId")
                        .HasName("PK__Voluntee__716F6F2C7FB85DFC");

                    b.HasIndex("AnimalId");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("YourPetPortfolio.Models.Employees", b =>
                {
                    b.HasOne("YourPetPortfolio.Models.Animals", "Animal")
                        .WithMany("Employees")
                        .HasForeignKey("AnimalId")
                        .HasConstraintName("FK__Employees__Anima__49C3F6B7");

                    b.HasOne("YourPetPortfolio.Models.Volunteers", "Volunteer")
                        .WithMany("Employees")
                        .HasForeignKey("VolunteerId")
                        .HasConstraintName("FK__Employees__Volun__48CFD27E");
                });

            modelBuilder.Entity("YourPetPortfolio.Models.Volunteers", b =>
                {
                    b.HasOne("YourPetPortfolio.Models.Animals", "Animal")
                        .WithMany("Volunteers")
                        .HasForeignKey("AnimalId")
                        .HasConstraintName("FK__Volunteer__Anima__45F365D3");
                });
#pragma warning restore 612, 618
        }
    }
}
