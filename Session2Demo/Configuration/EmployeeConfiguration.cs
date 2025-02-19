using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session2Demo.Entities;

namespace Session2Demo.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(E => E.Id);
            E.Property(E => E.Id)
             .UseIdentityColumn(10,10);

            E
                        .Property(E => E.Name)
                        .IsRequired()
                        .HasColumnName("EmployeeName")
                        .HasColumnType("varchar")
                        .HasMaxLength(100);

            E
                        .Property(E => E.Age)
                        .IsRequired(false);

            E.Property(E => E.Salary)
                         .HasColumnType("decimal(18,3)").IsRequired(false);
        }
    }
}
