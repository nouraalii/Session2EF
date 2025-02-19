using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Configuration
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.Id);
            I.Property(I => I.Name).IsRequired()
                                   .HasMaxLength(50);

            I.Property(I => I.Salary).HasColumnType("decimal(18,2)");

            I.Property(I => I.Address).HasColumnName("EmpAddress")
                                      .HasMaxLength(100);

            I.Property(I => I.HourRate).HasColumnType("decimal(10,2)");

            I.Property(I => I.Bonus).HasColumnType("decimal(10,2)");

            I.Property(I => I.DeptId).IsRequired();
        }
    }
}
