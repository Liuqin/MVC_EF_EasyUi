using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Sys_XcodeMap : EntityTypeConfiguration<Sys_Xcode>
    {
        public Sys_XcodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.codeSelf)
                .HasMaxLength(32);

            this.Property(t => t.codeRule)
                .HasMaxLength(32);

            this.Property(t => t.name)
                .HasMaxLength(32);

            this.Property(t => t.remark)
                .HasMaxLength(512);

            this.Property(t => t.depth)
                .HasMaxLength(64);

            this.Property(t => t.flag)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Sys_Xcode");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.codeSelf).HasColumnName("codeSelf");
            this.Property(t => t.codeRule).HasColumnName("codeRule");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.sort).HasColumnName("sort");
            this.Property(t => t.parentID).HasColumnName("parentID");
            this.Property(t => t.depth).HasColumnName("depth");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
