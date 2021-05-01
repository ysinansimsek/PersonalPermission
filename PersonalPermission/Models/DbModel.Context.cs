namespace PersonalPermission.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DboPersonalPermissionEntities : DbContext
    {
        public DboPersonalPermissionEntities()
            : base("name=DboPersonalPermissionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblPermission> TblPermissions { get; set; }
        public virtual DbSet<TblPersonal> TblPersonals { get; set; }
    }
}
