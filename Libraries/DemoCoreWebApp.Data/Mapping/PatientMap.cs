using DemoCoreWebApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoCoreWebApp.Data.Mapping
{
    public class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(400);
            builder.Property(c => c.LastName).HasMaxLength(400);
            builder.Property(c => c.MiddleName).HasMaxLength(400);
            builder.Property(c => c.DateOfBirth).HasMaxLength(400);
        }
    }
}
