using Nc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Nc.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class NcController : AbpController
    {
        protected NcController()
        {
            LocalizationResource = typeof(NcResource);
        }
    }
}