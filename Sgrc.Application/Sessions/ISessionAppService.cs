using System.Threading.Tasks;
using Abp.Application.Services;
using Sgrc.Sessions.Dto;

namespace Sgrc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
