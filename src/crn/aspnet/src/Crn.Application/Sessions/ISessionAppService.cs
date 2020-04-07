using System.Threading.Tasks;
using Abp.Application.Services;
using Crn.Sessions.Dto;

namespace Crn.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
