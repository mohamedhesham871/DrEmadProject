using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Cofig
{
	public class StudentCopnfig : IEntityTypeConfiguration<Student>
	{
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Email).IsRequired();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
        }
    }
}
