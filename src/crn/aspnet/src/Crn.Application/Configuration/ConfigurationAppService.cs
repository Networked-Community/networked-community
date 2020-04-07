using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Crn.Configuration.Dto;

namespace Crn.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CrnAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
