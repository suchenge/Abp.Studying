using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.Studying
{
    [Dependency(ReplaceServices = true)]
    public class StudyingBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Studying";
    }
}
