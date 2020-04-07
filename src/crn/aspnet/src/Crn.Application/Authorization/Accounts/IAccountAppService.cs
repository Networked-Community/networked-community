using System.Threading.Tasks;
using Abp.Application.Services;
using Crn.Authorization.Accounts.Dto;

namespace Crn.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
