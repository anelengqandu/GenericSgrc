using System.Linq;
using Sgrc.EntityFramework;
using Sgrc.MultiTenancy;

namespace Sgrc.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SgrcDbContext _context;

        public DefaultTenantCreator(SgrcDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
