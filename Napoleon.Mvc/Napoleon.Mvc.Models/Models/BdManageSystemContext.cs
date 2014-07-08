using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Napoleon.Mvc.Models.Models.Mapping;

namespace Napoleon.Mvc.Models.Models
{
    public partial class BdManageSystemContext : DbContext
    {
        static BdManageSystemContext()
        {
            Database.SetInitializer<BdManageSystemContext>(null);
        }

        public BdManageSystemContext()
            : base("Name=BdManageSystemContext")
        {
        }

        public DbSet<Base_City> Base_City { get; set; }
        public DbSet<Base_Company> Base_Company { get; set; }
        public DbSet<Base_GoodsInfo> Base_GoodsInfo { get; set; }
        public DbSet<Base_ManProjects> Base_ManProjects { get; set; }
        public DbSet<Base_ProjectInfo> Base_ProjectInfo { get; set; }
        public DbSet<Base_User> Base_User { get; set; }
        public DbSet<Sys_Error> Sys_Error { get; set; }
        public DbSet<Sys_Lcode> Sys_Lcode { get; set; }
        public DbSet<Sys_Purview> Sys_Purview { get; set; }
        public DbSet<Sys_Xcode> Sys_Xcode { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Base_CityMap());
            modelBuilder.Configurations.Add(new Base_CompanyMap());
            modelBuilder.Configurations.Add(new Base_GoodsInfoMap());
            modelBuilder.Configurations.Add(new Base_ManProjectsMap());
            modelBuilder.Configurations.Add(new Base_ProjectInfoMap());
            modelBuilder.Configurations.Add(new Base_UserMap());
            modelBuilder.Configurations.Add(new Sys_ErrorMap());
            modelBuilder.Configurations.Add(new Sys_LcodeMap());
            modelBuilder.Configurations.Add(new Sys_PurviewMap());
            modelBuilder.Configurations.Add(new Sys_XcodeMap());
        }
    }
}
