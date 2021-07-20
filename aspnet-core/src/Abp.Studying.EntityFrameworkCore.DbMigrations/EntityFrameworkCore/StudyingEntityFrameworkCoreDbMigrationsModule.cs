using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Abp.Studying.EntityFrameworkCore
{
    [DependsOn(
        typeof(StudyingEntityFrameworkCoreModule)
        )]
    public class StudyingEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StudyingMigrationsDbContext>();
        }
    }
}
