using System.Threading.Tasks;
using Crn.Configuration.Dto;

namespace Crn.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
