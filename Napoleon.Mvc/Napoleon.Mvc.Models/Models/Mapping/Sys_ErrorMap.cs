using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Sys_ErrorMap : EntityTypeConfiguration<Sys_Error>
    {
        public Sys_ErrorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.userName)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Sys_Error");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.stackTrace).HasColumnName("stackTrace");
            this.Property(t => t.targetSite).HasColumnName("targetSite");
            this.Property(t => t.userName).HasColumnName("userName");
            this.Property(t => t.errorTime).HasColumnName("errorTime");
        }
    }
}
