using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Studying.Data
{
    /* This is used if database provider does't define
     * IStudyingDbSchemaMigrator implementation.
     */
    public class NullStudyingDbSchemaMigrator : IStudyingDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}