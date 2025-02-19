﻿// <auto-generated />
using System;
using Assignment.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(AssignmentDbContext))]
    [Migration("20250219174025_AssignmentCreation")]
    partial class AssignmentCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment.Entities.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Top_ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Assignment.Entities.Course_Inst", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Inst_ID")
                        .HasColumnType("int");

                    b.Property<string>("Evaluate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Course_ID", "Inst_ID");

                    b.HasIndex("Inst_ID");

                    b.ToTable("CourseInsts");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("date");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("DepartmentName");

                    b.HasKey("ID");

                    b.HasIndex("InstructorId")
                        .IsUnique()
                        .HasFilter("[InstructorId] IS NOT NULL");

                    b.ToTable("Department", "dbo");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("EmpAddress");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Assignment.Entities.Stud_Course", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Stud_ID")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.HasKey("Course_ID", "Stud_ID");

                    b.HasIndex("Stud_ID");

                    b.ToTable("StudCourses");
                });

            modelBuilder.Entity("Assignment.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("Dep_Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Assignment.Entities.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Assignment.Entities.Course", b =>
                {
                    b.HasOne("Assignment.Entities.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("Top_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Assignment.Entities.Course_Inst", b =>
                {
                    b.HasOne("Assignment.Entities.Course", "Course")
                        .WithMany("CourseInsts")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Entities.Instructor", "Instructor")
                        .WithMany("CourseInsts")
                        .HasForeignKey("Inst_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.HasOne("Assignment.Entities.Instructor", "Instructor")
                        .WithOne("Department")
                        .HasForeignKey("Assignment.Entities.Department", "InstructorId");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Assignment.Entities.Stud_Course", b =>
                {
                    b.HasOne("Assignment.Entities.Course", "Course")
                        .WithMany("StudCourses")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Entities.Student", "Student")
                        .WithMany("StudCourses")
                        .HasForeignKey("Stud_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Assignment.Entities.Student", b =>
                {
                    b.HasOne("Assignment.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("Dep_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment.Entities.Course", b =>
                {
                    b.Navigation("CourseInsts");

                    b.Navigation("StudCourses");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.Navigation("CourseInsts");

                    b.Navigation("Department")
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment.Entities.Student", b =>
                {
                    b.Navigation("StudCourses");
                });

            modelBuilder.Entity("Assignment.Entities.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
