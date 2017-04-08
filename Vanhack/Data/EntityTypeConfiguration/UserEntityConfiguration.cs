using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class UserEntityConfiguration : EntityTypeConfiguration<UserModel>
    {
        public UserEntityConfiguration()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("IDUSER")
                .IsRequired();

            this.Property(c => c.FirstName)
                .HasColumnName("FIRSTNAME");

            this.Property(c => c.LastName)
                .HasColumnName("LASTNAME");

            this.Property(c => c.Email)
                .HasColumnName("EMAIL");

            this.Property(c => c.Bio)
                .HasColumnName("Bio");

            this.Property(c => c.BornDate)
                .HasColumnName("BornDate");

            this.Property(c => c.CurrentEmployer)
                .HasColumnName("CurrentEmployer");

            this.Property(c => c.Position)
                .HasColumnName("Position");

            this.Property(c => c.EnglishLevel)
                .HasColumnName("EnglishLevel");

            this.Property(c => c.YearsOfExperience)
                .HasColumnName("YearsOfExperience");

            this.Property(c => c.Skills)
                .HasColumnName("Skills");

            this.Property(c => c.WebSite)
                .HasColumnName("WebSite");

            this.Property(c => c.GitHub)
                .HasColumnName("GitHub");

            this.Property(c => c.Linkedin)
                .HasColumnName("LinkedIn");

            this.Property(c => c.PrincipalSkill)
                .HasColumnName("PRINCIPALSKILL");

            this.Property(c => c.CvChecked)
                .HasColumnName("CVCHECKED");

            this.ToTable("user");
        }
    }
}