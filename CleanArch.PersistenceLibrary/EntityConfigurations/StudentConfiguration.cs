using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.CoreLibrary.Models;

namespace CleanArch.PersistenceLibrary.EntityConfigurations
{
    public class StudentConfiguration:EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            Property(s => s.Code)
                .IsRequired()
                .HasMaxLength(100);

            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(s => s.Roll)
                .IsRequired()
                .HasMaxLength(10);

            Property(s => s.DepartmentId)
                .IsRequired();
        }
    }
}
