using System.Data.Entity;
using Vanhack.Data.EntityTypeConfiguration;
using Vanhack.Models;

namespace Vanhack.Data
{
    public class VhDbContext : DbContext
    {
        public VhDbContext():base("connection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<CompanyModel> Company  { get; set; }

        public DbSet<EducationModel> Education { get; set; }

        public DbSet<JobByUserModel> JobByUser { get; set; }

        public DbSet<JobByUserLog> JobByUserLog { get; set; }

        public DbSet<JobExperienceModel> JobExperience { get; set; }

        public DbSet<JobModel> JobModel { get; set; }

        public DbSet<JobPositionModel> JobPosition { get; set; }

        public DbSet<JobSkillModel> JobSkill { get; set; }

        public DbSet<SkillModel> Skill { get; set; }

        public DbSet<UserModel> User { get; set; }

        public DbSet<UserSkillModel> UserSkill { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CompanyEntityConfigurationType());
            modelBuilder.Configurations.Add(new EducationEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new JobByUserEntityConfiguration());
            modelBuilder.Configurations.Add(new JobByUserLogEntityConfiguration());
            modelBuilder.Configurations.Add(new JobEntityConfiguration());
            modelBuilder.Configurations.Add(new JobExperienceEntityConfiguration());
            modelBuilder.Configurations.Add(new JobPositionEntityConfiguration());
            modelBuilder.Configurations.Add(new JobSkillEntityConfiguration());
            modelBuilder.Configurations.Add(new SkillEntityConfiguration());
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new UserSkillEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}