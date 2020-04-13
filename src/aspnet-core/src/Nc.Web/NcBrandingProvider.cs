using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Nc.Web
{
    [Dependency(ReplaceServices = true)]
    public class NcBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Nc";
    }
}
