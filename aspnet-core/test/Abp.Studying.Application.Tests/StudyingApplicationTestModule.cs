using Volo.Abp.Modularity;

namespace Abp.Studying
{
    [DependsOn(
        typeof(StudyingApplicationModule),
        typeof(StudyingDomainTestModule)
        )]
    public class StudyingApplicationTestModule : AbpModule
    {

    }
}