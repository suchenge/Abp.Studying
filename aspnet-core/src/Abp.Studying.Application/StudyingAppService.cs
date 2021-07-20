using System;
using System.Collections.Generic;
using System.Text;
using Abp.Studying.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Studying
{
    /* Inherit your application services from this class.
     */
    public abstract class StudyingAppService : ApplicationService
    {
        protected StudyingAppService()
        {
            LocalizationResource = typeof(StudyingResource);
        }
    }
}
