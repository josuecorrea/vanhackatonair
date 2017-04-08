using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class JobEntityConfiguration : EntityTypeConfiguration<JobModel>
    {
        public JobEntityConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("IDJOB")
                .IsRequired();

            this.Property(c => c.AboutUs)
                .HasColumnName("AboutUs");

            this.Property(c => c.AboutYourTeam)
                .HasColumnName("AboutYourTeam");

            this.Property(c => c.AboutThisRole)
                .HasColumnName("AboutThisRole");

            this.Property(c => c.Responsibilities)
                .HasColumnName("Responsibilities");

            this.Property(c => c.Qualifications)
                .HasColumnName("Qualifications");

            this.Property(c => c.Benefits)
                .HasColumnName("Benefits");

            this.Property(c => c.JobType)
                .HasColumnName("JOBTYPE");

            this.Property(c => c.PostDate)
                .HasColumnName("POSTDATE");

            this.Property(c => c.EndDate)
                .HasColumnName("ENDDATE");

            this.Property(c => c.Email)
                .HasColumnName("EMAIL");

            this.Property(c => c.Deleted)
                .HasColumnName("DELETED");

            this.Property(c => c.City)
                .HasColumnName("CITY");

            this.Property(c => c.Country)
               .HasColumnName("COUNTRY");

            this.Property(c => c.UserId)
                .HasColumnName("IDUSER")
                .IsRequired();

            this.Property(c => c.JobPositionId)
                .HasColumnName("IDJOBPOSITION");

            this.Property(c => c.PrincipalSkill)
                .HasColumnName("PRINCIPALSKILL");

            this.Property(c => c.CompanyId)
                .HasColumnName("IDCOMPANY");

            this.Property(c => c.Position)
                .HasColumnName("POSITION");

            this.Property(c => c.Applied)
                .HasColumnName("APPLIED");

            this.Property(c => c.RemoteJob)
                .HasColumnName("REMOTEJOB");

            this.Property(c => c.Private)
                .HasColumnName("PRIVATE");

            this.Property(c => c.UserRecruiterId)
                .HasColumnName("IDUSERRECRUITER");

            this.Property(c => c.Salary)
                .HasColumnName("Salary");

            this.Property(c => c.Commission)
                .HasColumnName("Commission");

            this.Property(c => c.NumberOfPosition)
                .HasColumnName("NumberOfPosition");

            this.Property(c => c.YearOfExperience)
                .HasColumnName("YearsOfExperience");

            this.HasRequired(c => c.JobPosition)
                .WithMany()
                .HasForeignKey(c => c.JobPositionId);

            this.HasRequired(c => c.Company)
                .WithMany()
                .HasForeignKey(c => c.CompanyId);

            this.ToTable("job");

        }
    }
}