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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D=>D.DeptId);
            builder.Property(D=>D.DeptId).UseIdentityColumn(100,100);
            builder.Property(D=>D.Name).HasColumnName("DepartmentName")
                                        .HasMaxLength(50)
                                        .HasColumnType("varchar");
        }
    }
}
