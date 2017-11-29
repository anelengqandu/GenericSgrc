using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Sgrc.EntityFramework;

namespace Sgrc.Migrator
{
    [DependsOn(typeof(SgrcDataModule))]
    public class SgrcMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SgrcDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}