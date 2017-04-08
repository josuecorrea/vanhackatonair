using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class UserSkillEntityConfiguration : EntityTypeConfiguration<UserSkillModel>
    {
        public UserSkillEntityConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("ID")
                .IsRequired();

            this.Property(c => c.UserId)
               .HasColumnName("IDUSER")
               .IsRequired();

            this.Property(c => c.SkillId)
                .HasColumnName("IDSKILL")
                .IsRequired();

            this.Property(c => c.YeatsOfExperience)
               .HasColumnName("YEARSOFEXPERIENCE")
               .IsRequired();

            this.HasRequired(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);

            this.HasRequired(c => c.Skill)
                .WithMany()
                .HasForeignKey(c => c.SkillId);

            this.ToTable("userskill");
        }
    }
}