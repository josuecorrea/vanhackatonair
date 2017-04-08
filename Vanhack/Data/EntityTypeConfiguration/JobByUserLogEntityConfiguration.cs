using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class JobByUserLogEntityConfiguration : EntityTypeConfiguration<JobByUserLog>
    {
        public JobByUserLogEntityConfiguration()
        {
            this.HasKey(c => c.Id);


            this.Property(c => c.Id)
                .HasColumnName("IDJOBBYUSERLOG")
                .IsRequired();

            this.Property(c => c.Date)
                .HasColumnName("Date")
                .IsRequired();

            this.Property(c => c.ApplicationsStatus)
                .HasColumnName("ApplicationStatus")
                .IsRequired();

            this.Property(c => c.JobByUserId)
                .HasColumnName("IDJOBBYUSER")
                .IsRequired();

            this.Property(c => c.IdUserApplcation)
                .HasColumnName("IDUSERAPPLICATION")
                .IsRequired();

            this.HasRequired(c => c.JobByUser)
                .WithMany()
                .HasForeignKey(c => c.JobByUserId);
        }
    }
}