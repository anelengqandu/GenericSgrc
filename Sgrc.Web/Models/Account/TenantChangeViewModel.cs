using Abp.AutoMapper;
using Sgrc.Sessions.Dto;

namespace Sgrc.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}