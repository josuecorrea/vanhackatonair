using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class JobPositionEntityConfiguration : EntityTypeConfiguration<JobPositionModel>
    {
        public JobPositionEntityConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("IDJOBPOSITION")
                .IsRequired();

            this.Property(c => c.Position)
                .HasColumnName("POSITION")
                .IsRequired();

            this.ToTable("jobposition");
        }
    }
}