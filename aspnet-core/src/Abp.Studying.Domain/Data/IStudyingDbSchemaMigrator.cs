using System.Threading.Tasks;

namespace Abp.Studying.Data
{
    public interface IStudyingDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
