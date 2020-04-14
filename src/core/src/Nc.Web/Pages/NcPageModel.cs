using Nc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Nc.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class NcPageModel : AbpPageModel
    {
        protected NcPageModel()
        {
            LocalizationResourceType = typeof(NcResource);
        }
    }
}