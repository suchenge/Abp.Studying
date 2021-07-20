using Abp.Studying.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Studying
{
    [DependsOn(
        typeof(StudyingEntityFrameworkCoreTestModule)
        )]
    public class StudyingDomainTestModule : AbpModule
    {

    }
}