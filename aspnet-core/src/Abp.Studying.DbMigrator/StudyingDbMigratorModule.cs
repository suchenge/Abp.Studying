using Abp.Studying.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abp.Studying.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(StudyingEntityFrameworkCoreDbMigrationsModule),
        typeof(StudyingApplicationContractsModule)
        )]
    public class StudyingDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
