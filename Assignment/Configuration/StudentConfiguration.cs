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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(S => S.ID);

            S.Property(S => S.FName)
             .IsRequired()
             .HasMaxLength(50);

            S.Property(S => S.LName)
             .IsRequired()
             .HasMaxLength(50);

            S.Property(S => S.Address)
             .HasMaxLength(100);

            S.Property(S => S.Age)
             .IsRequired(false);

            S.Property(S => S.Dep_Id).IsRequired();
        }
    }
}
