using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class JobSkillEntityConfiguration : EntityTypeConfiguration<JobSkillModel>
    {
        public JobSkillEntityConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("ID")
                .IsRequired();

            this.Property(c => c.SkillId)
                .HasColumnName("IDSKILL")
                .IsRequired();

            this.Property(c => c.JobId)
                .HasColumnName("IDJOB")
                .IsRequired();

            this.HasRequired(c => c.Job)
                .WithMany()
                .HasForeignKey(c => c.JobId);

            this.HasRequired(c => c.Skill)
                .WithMany()
                .HasForeignKey(c => c.SkillId);

            this.ToTable("jobskill");
        }
    }
}