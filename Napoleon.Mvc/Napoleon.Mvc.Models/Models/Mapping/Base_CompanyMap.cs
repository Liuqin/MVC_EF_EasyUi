using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Base_CompanyMap : EntityTypeConfiguration<Base_Company>
    {
        public Base_CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.companyName)
                .HasMaxLength(128);

            this.Property(t => t.companyPerson)
                .HasMaxLength(32);

            this.Property(t => t.companyPhone)
                .HasMaxLength(32);

            this.Property(t => t.mobilePhone)
                .HasMaxLength(32);

            this.Property(t => t.personPostion)
                .HasMaxLength(32);

            this.Property(t => t.companyAddress)
                .HasMaxLength(128);

            this.Property(t => t.companyCity)
                .HasMaxLength(32);

            this.Property(t => t.postCode)
                .HasMaxLength(32);

            this.Property(t => t.nsrXz)
                .HasMaxLength(32);

            this.Property(t => t.notes)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Base_Company");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.companyName).HasColumnName("companyName");
            this.Property(t => t.companyPerson).HasColumnName("companyPerson");
            this.Property(t => t.companyPhone).HasColumnName("companyPhone");
            this.Property(t => t.mobilePhone).HasColumnName("mobilePhone");
            this.Property(t => t.personPostion).HasColumnName("personPostion");
            this.Property(t => t.companyAddress).HasColumnName("companyAddress");
            this.Property(t => t.companyCity).HasColumnName("companyCity");
            this.Property(t => t.postCode).HasColumnName("postCode");
            this.Property(t => t.nsrXz).HasColumnName("nsrXz");
            this.Property(t => t.notes).HasColumnName("notes");
        }
    }
}
