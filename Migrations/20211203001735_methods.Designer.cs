﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtilioFinal.Models;

namespace OtilioFinal.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211203001735_methods")]
    partial class methods
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("OtilioFinal.Models.Departament", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("OtilioFinal.Models.SalesRecord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Sellerid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Sellerid");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("OtilioFinal.Models.Seller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Departmentid")
                        .HasColumnType("int");

                    b.Property<double>("baseSalary")
                        .HasColumnType("double");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Departmentid");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("OtilioFinal.Models.SalesRecord", b =>
                {
                    b.HasOne("OtilioFinal.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("Sellerid");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("OtilioFinal.Models.Seller", b =>
                {
                    b.HasOne("OtilioFinal.Models.Departament", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("Departmentid");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("OtilioFinal.Models.Departament", b =>
                {
                    b.Navigation("Sellers");
                });

            modelBuilder.Entity("OtilioFinal.Models.Seller", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
