using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Nc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Nc.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Nc.Web.Pages.NcPage
     */
    public abstract class NcPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<NcResource> L { get; set; }
    }
}
