using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class JobByUserEntityConfiguration : EntityTypeConfiguration<JobByUserModel>
    {
        public JobByUserEntityConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("IDJOBBYUSER")
                .IsRequired();

            this.Property(c => c.Applied)
                .HasColumnName("APPLIED")
                .IsRequired();

            this.Property(c => c.Data)
                .HasColumnName("DATA")
                .IsRequired();

            this.Property(c => c.Contanted)
                .HasColumnName("CONTACTED")
                .IsRequired();

            this.Property(c => c.UserId)
                .HasColumnName("IDUSER")
                .IsRequired();

            this.Property(c => c.JobId)
                .HasColumnName("IDJOB")
                .IsRequired();
            
            this.Property(c => c.Favorite)
                .HasColumnName("FAVORITE")
                .IsRequired();

            this.Property(c => c.ApplicationStatus)
                .HasColumnName("APPLICATIONSTATUS")
                .IsRequired();

            this.Property(c => c.AreYouGoodForThisJob)
                .HasColumnName("AREYOUGOODFORTHISJOB")
                .IsRequired();

            this.HasRequired(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);
          
            this.ToTable("jobbyuser");
        }
    }
}