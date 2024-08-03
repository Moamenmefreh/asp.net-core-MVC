﻿// <auto-generated />
using System;
using Center.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Center.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Center.Models.Matrial", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("SunbjectName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("Matrials");
                });

            modelBuilder.Entity("Center.Models.MatrialsRecord", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<bool>("Arabic")
                        .HasColumnType("bit");

                    b.Property<bool>("Biology")
                        .HasColumnType("bit");

                    b.Property<bool>("English")
                        .HasColumnType("bit");

                    b.Property<bool>("Math")
                        .HasColumnType("bit");

                    b.Property<bool>("Physics")
                        .HasColumnType("bit");

                    b.HasKey("StudentId");

                    b.ToTable("MatrialsRecord");
                });

            modelBuilder.Entity("Center.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Center.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MatrialCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Specialization")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatrialCode");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("MatrialStudent", b =>
                {
                    b.Property<string>("MatrialsCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("MatrialsCode", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("MatrialStudent");
                });

            modelBuilder.Entity("Center.Models.Teacher", b =>
                {
                    b.HasOne("Center.Models.Matrial", null)
                        .WithMany("Teacher")
                        .HasForeignKey("MatrialCode");

                    b.HasOne("Center.Models.Teacher", null)
                        .WithMany("Teachers")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("MatrialStudent", b =>
                {
                    b.HasOne("Center.Models.Matrial", null)
                        .WithMany()
                        .HasForeignKey("MatrialsCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Center.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Center.Models.Matrial", b =>
                {
                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Center.Models.Teacher", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
