using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Base_UserMap : EntityTypeConfiguration<Base_User>
    {
        public Base_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.realName)
                .HasMaxLength(32);

            this.Property(t => t.userName)
                .HasMaxLength(32);

            this.Property(t => t.passWord)
                .HasMaxLength(32);

            this.Property(t => t.mobilePhone)
                .HasMaxLength(32);

            this.Property(t => t.companyName)
                .HasMaxLength(128);

            this.Property(t => t.companyAddress)
                .HasMaxLength(128);

            this.Property(t => t.companyCity)
                .HasMaxLength(32);

            this.Property(t => t.postCode)
                .HasMaxLength(32);

            this.Property(t => t.notes)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Base_User");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.realName).HasColumnName("realName");
            this.Property(t => t.userName).HasColumnName("userName");
            this.Property(t => t.passWord).HasColumnName("passWord");
            this.Property(t => t.mobilePhone).HasColumnName("mobilePhone");
            this.Property(t => t.isUse).HasColumnName("isUse");
            this.Property(t => t.userType).HasColumnName("userType");
            this.Property(t => t.companyName).HasColumnName("companyName");
            this.Property(t => t.companyAddress).HasColumnName("companyAddress");
            this.Property(t => t.companyCity).HasColumnName("companyCity");
            this.Property(t => t.postCode).HasColumnName("postCode");
            this.Property(t => t.notes).HasColumnName("notes");
        }
    }
}
