using System.Threading.Tasks;
using Abp.Application.Services;
using Sgrc.Authorization.Accounts.Dto;

namespace Sgrc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
