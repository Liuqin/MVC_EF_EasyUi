using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Base_ProjectInfoMap : EntityTypeConfiguration<Base_ProjectInfo>
    {
        public Base_ProjectInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.userID)
                .HasMaxLength(32);

            this.Property(t => t.projectName)
                .HasMaxLength(128);

            this.Property(t => t.projectCostInfo)
                .HasMaxLength(128);

            this.Property(t => t.notes)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Base_ProjectInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.companyID).HasColumnName("companyID");
            this.Property(t => t.userID).HasColumnName("userID");
            this.Property(t => t.projectName).HasColumnName("projectName");
            this.Property(t => t.contractDate).HasColumnName("contractDate");
            this.Property(t => t.projectCost).HasColumnName("projectCost");
            this.Property(t => t.projectCostEndDate).HasColumnName("projectCostEndDate");
            this.Property(t => t.invoiceDate).HasColumnName("invoiceDate");
            this.Property(t => t.projectCostInfo).HasColumnName("projectCostInfo");
            this.Property(t => t.notes).HasColumnName("notes");
        }
    }
}
