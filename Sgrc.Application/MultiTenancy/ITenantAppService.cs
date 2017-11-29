using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sgrc.MultiTenancy.Dto;

namespace Sgrc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
