using Abp.Studying.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Studying.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class StudyingController : AbpController
    {
        protected StudyingController()
        {
            LocalizationResource = typeof(StudyingResource);
        }
    }
}