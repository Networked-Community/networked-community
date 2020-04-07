using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Crn.Controllers
{
    public abstract class CrnControllerBase: AbpController
    {
        protected CrnControllerBase()
        {
            LocalizationSourceName = CrnConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
