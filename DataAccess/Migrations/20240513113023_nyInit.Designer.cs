﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20240513113023_nyInit")]
    partial class nyInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EducationLawyer", b =>
                {
                    b.Property<int>("EducationsId")
                        .HasColumnType("int");

                    b.Property<int>("LawyerId")
                        .HasColumnType("int");

                    b.HasKey("EducationsId", "LawyerId");

                    b.HasIndex("LawyerId");

                    b.ToTable("EducationLawyer");
                });

            modelBuilder.Entity("Models.AppliedService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CaseId")
                        .HasColumnType("int");

                    b.Property<int>("LawyerId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServicePerformed")
                        .HasColumnType("datetime2");

                    b.Property<double?>("StartPaymentActual")
                        .HasColumnType("float");

                    b.Property<double?>("UnitCostActual")
                        .HasColumnType("float");

                    b.Property<int?>("UnitCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("LawyerId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppliedServices");
                });

            modelBuilder.Entity("Models.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("CaseClosed")
                        .HasColumnType("bit");

                    b.Property<string>("CaseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EstimatedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("Subscribed")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateHired")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("WorkPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");
                });

            modelBuilder.Entity("Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OneTimePayment")
                        .HasColumnType("bit");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("StartPaymentDefault")
                        .HasColumnType("float");

                    b.Property<double?>("UnitCostDefault")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Models.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitTypes");
                });

            modelBuilder.Entity("Models.Zipcode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postal")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.ToTable("Zipcodes");
                });

            modelBuilder.Entity("Models.Lawyer", b =>
                {
                    b.HasBaseType("Models.Employee");

                    b.HasDiscriminator().HasValue("Lawyer");
                });

            modelBuilder.Entity("EducationLawyer", b =>
                {
                    b.HasOne("Models.Education", null)
                        .WithMany()
                        .HasForeignKey("EducationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Lawyer", null)
                        .WithMany()
                        .HasForeignKey("LawyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.AppliedService", b =>
                {
                    b.HasOne("Models.Case", null)
                        .WithMany("AppliedServices")
                        .HasForeignKey("CaseId");

                    b.HasOne("Models.Lawyer", "Lawyer")
                        .WithMany("AppliedServices")
                        .HasForeignKey("LawyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lawyer");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Models.Case", b =>
                {
                    b.HasOne("Models.Client", "Client")
                        .WithMany("Cases")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Models.Case", b =>
                {
                    b.Navigation("AppliedServices");
                });

            modelBuilder.Entity("Models.Client", b =>
                {
                    b.Navigation("Cases");
                });

            modelBuilder.Entity("Models.Lawyer", b =>
                {
                    b.Navigation("AppliedServices");
                });
#pragma warning restore 612, 618
        }
    }
}
