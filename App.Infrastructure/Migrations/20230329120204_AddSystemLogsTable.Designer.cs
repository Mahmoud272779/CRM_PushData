﻿// <auto-generated />
using System;
using App.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Infrastructure.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20230329120204_AddSystemLogsTable")]
    partial class AddSystemLogsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Domain.Entities.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latinName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            arabicName = "مدير النظام",
                            latinName = "Administrator"
                        });
                });

            modelBuilder.Entity("App.Domain.Entities.PermissionList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("arabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latinName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PermissionList");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            arabicName = "مدير النظام",
                            latinName = "System Administrator"
                        });
                });

            modelBuilder.Entity("App.Domain.Entities.Rules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("canAdd")
                        .HasColumnType("bit");

                    b.Property<bool>("canDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("canEdit")
                        .HasColumnType("bit");

                    b.Property<bool>("canOpen")
                        .HasColumnType("bit");

                    b.Property<bool>("canPrint")
                        .HasColumnType("bit");

                    b.Property<int>("permissionListId")
                        .HasColumnType("int");

                    b.Property<int>("screenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("permissionListId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("App.Domain.Entities.SystemLogsHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<byte[]>("NewFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("OldFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("actionId")
                        .HasColumnType("int");

                    b.Property<int>("companyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("reportId")
                        .HasColumnType("int");

                    b.Property<int>("screenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("SystemLogsHistory");
                });

            modelBuilder.Entity("App.Domain.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("arabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employeesId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("latinName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("permissionListId")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("employeesId");

                    b.HasIndex("permissionListId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            arabicName = "مدير النظام",
                            employeesId = -1,
                            isActive = true,
                            latinName = "administrator",
                            password = "admin",
                            permissionListId = -1,
                            username = "admin"
                        });
                });

            modelBuilder.Entity("App.Domain.Entities.Rules", b =>
                {
                    b.HasOne("App.Domain.Entities.PermissionList", "permissionList")
                        .WithMany("rules")
                        .HasForeignKey("permissionListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permissionList");
                });

            modelBuilder.Entity("App.Domain.Entities.SystemLogsHistory", b =>
                {
                    b.HasOne("App.Domain.Entities.Employees", "Employees")
                        .WithMany("SystemLogsHistory")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("App.Domain.Entities.Users", b =>
                {
                    b.HasOne("App.Domain.Entities.Employees", "employees")
                        .WithMany("users")
                        .HasForeignKey("employeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Entities.PermissionList", "permissionList")
                        .WithMany("users")
                        .HasForeignKey("permissionListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employees");

                    b.Navigation("permissionList");
                });

            modelBuilder.Entity("App.Domain.Entities.Employees", b =>
                {
                    b.Navigation("SystemLogsHistory");

                    b.Navigation("users");
                });

            modelBuilder.Entity("App.Domain.Entities.PermissionList", b =>
                {
                    b.Navigation("rules");

                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
