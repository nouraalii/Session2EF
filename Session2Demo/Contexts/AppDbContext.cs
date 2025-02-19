using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session2Demo.Configuration;
using Session2Demo.Entities;

namespace Session2Demo.Contexts
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Employee>().HasKey("Id");
            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.Id));

            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().Property(E => E.Id).UseIdentityColumn(10,10);
            //modelBuilder.Entity<Employee>().Property(E => E.Name)
            //                            .HasColumnName("EmpName")
            //                            .HasColumnType("varchar")
            //                            .HasMaxLength(50)
            //                            .IsRequired();

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region MyRegion
            /*//modelBuilder.Entity<Employee>().HasKey("EmpId");
                //modelBuilder.Entity<Employee>().HasKey(nameof(Employee));
                modelBuilder.Entity<Employee>().HasKey(E=>E.EmpId);

                modelBuilder.Entity<Employee>()
                            .Property(E => E.Name)
                            .IsRequired()
                            .HasColumnName("EmployeeName")
                            .HasColumnType("varchar")
                            .HasMaxLength(50);

                modelBuilder.Entity<Employee>()
                            .Property(E => E.Age)
                            .IsRequired(false);

                modelBuilder.Entity<Employee>()
                            .Property(E => E.Salary)
                            .HasColumnType("money");*//*

                //modelBuilder.Entity<Employee>().Property(E => E.DataOfCreation).HasDefaultValue(DateTime.Now);
                //modelBuilder.Entity<Employee>().Property(E => E.DataOfCreation).HasDefaultValueSql("GETDATE()");

                modelBuilder.Entity<Employee>(E =>
                {
                    E.HasKey(E => E.EmpId);

                    E
                                .Property(E => E.Name)
                                .IsRequired()
                                .HasColumnName("EmployeeName")
                                .HasColumnType("varchar")
                                .HasMaxLength(50);

                    E
                                .Property(E => E.Age)
                                .IsRequired(false);

                   E.Property(E => E.Salary)
                                .HasColumnType("money"); 

                    //E.Property(E => E.DataOfCreation).HasDefaultValue(DateTime.Now);
                    E.Property(E => E.DataOfCreation).HasDefaultValueSql("GETDATE()");
                });*/
            #endregion


            //Relations

            //modelBuilder.Entity<Employee>().HasOne(E => E.Department)
            //                               .WithOne(D => D.Manager)
            //                               .HasForeignKey<Department>(D=>D.EmpId);

            //modelBuilder.Entity<Department>().HasOne(D => D.Manager)
            //                                 .WithOne(E => E.Department)
            //                                 .HasForeignKey<Department>(D => D.EmpId); 

            modelBuilder.Entity<Stud_Course>().HasKey(SC => new {SC.CourseId,SC.StudentId});

            base.OnModelCreating(modelBuilder);
        }

        public AppDbContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = DemoEFCore2; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
