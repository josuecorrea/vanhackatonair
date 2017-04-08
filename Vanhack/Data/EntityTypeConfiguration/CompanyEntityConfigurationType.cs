using System.Data.Entity.ModelConfiguration;
using Vanhack.Models;

namespace Vanhack.Data.EntityTypeConfiguration
{
    public class CompanyEntityConfigurationType : EntityTypeConfiguration<CompanyModel>
    {
        public CompanyEntityConfigurationType()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("IDCOMPANY")
                .IsRequired();

            this.Property(c => c.Name)
                .HasColumnName("NAME")
                .IsRequired();
            
            this.Property(c => c.Summary)
                .HasColumnName("SUMARY")
                .IsRequired();


            this.Property(c => c.Phone)
                .HasColumnName("PHONE")
                .IsRequired();

            this.Property(c => c.WebSite)
                .HasColumnName("WEBSITE")
                .IsRequired();

            this.Property(c => c.City)
                .HasColumnName("CITY")
                .IsRequired();

            this.Property(c => c.Province)
                .HasColumnName("PROVINCE")
                .IsRequired();

            this.Property(c => c.Country)
                .HasColumnName("COUNTRY")
                .IsRequired();

            this.Property(c => c.Favourite)
                .HasColumnName("FAVOURITE")
                .IsRequired();

            this.Property(c => c.Image)
                .HasColumnName("IMAGE")
                .IsRequired();

            this.ToTable("company");
        }
    }
}