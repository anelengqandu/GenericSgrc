using System.Data.Common;
using Abp.Zero.EntityFramework;
using Sgrc.Authorization.Roles;
using Sgrc.Authorization.Users;
using Sgrc.MultiTenancy;

namespace Sgrc.EntityFramework
{
    public class SgrcDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SgrcDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SgrcDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SgrcDbContext since ABP automatically handles it.
         */
        public SgrcDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SgrcDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SgrcDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
