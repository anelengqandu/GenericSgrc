using Sgrc.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Sgrc.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SgrcDbContext _context;

        public InitialHostDbBuilder(SgrcDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
