using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class SkillEntityConfiguration : EntityTypeConfiguration<SkillModel>
    {
        public SkillEntityConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("IDSKILL")
                .IsRequired();

            this.Property(c => c.SkillName)
                .HasColumnName("SKILLNAME")
                .IsRequired();

            this.Property(c => c.Active)
                .HasColumnName("ACTIVE")
                .IsRequired();

            this.Property(c => c.ApprovalDate)
                .HasColumnName("APPROVALDATE")
                .IsRequired();

            this.ToTable("skill");
        }
    }
}