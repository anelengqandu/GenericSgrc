using System.Threading.Tasks;
using Abp.Application.Services;
using Sgrc.Configuration.Dto;

namespace Sgrc.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}