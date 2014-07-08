using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Sys_PurviewMap : EntityTypeConfiguration<Sys_Purview>
    {
        public Sys_PurviewMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.userType)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Sys_Purview");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.userType).HasColumnName("userType");
            this.Property(t => t.listCode).HasColumnName("listCode");
        }
    }
}
