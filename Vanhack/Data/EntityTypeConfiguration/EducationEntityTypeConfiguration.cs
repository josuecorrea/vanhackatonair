using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class EducationEntityTypeConfiguration : EntityTypeConfiguration<EducationModel>
    {
        public EducationEntityTypeConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("IDEDUCATION")
                .IsRequired();

            this.Property(c => c.Name)
                .HasColumnName("NAME")
                .IsRequired();

            this.Property(c => c.Location)
                .HasColumnName("LOCATION")
                .IsRequired();

            this.Property(c => c.Start)
                .HasColumnName("START")
                .IsRequired();

            this.Property(c => c.Course)
                .HasColumnName("COURSE")
                .IsRequired();
            
            this.Property(c => c.End)
                .HasColumnName("END")
                .IsRequired();

            this.Property(c => c.UserId)
                .HasColumnName("IDUSER")
                .IsRequired();

            this.Property(c => c.Order)
                .HasColumnName("ORDER")
                .IsRequired();

            this.Property(c => c.StateProvince)
                .HasColumnName("STATEPROVINCE")
                .IsRequired();

            this.Property(c => c.Country)
                .HasColumnName("COUNTRY")
                .IsRequired();

            this.HasRequired(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);

            this.ToTable("education");
        }
    }
}