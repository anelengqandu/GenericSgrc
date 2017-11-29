using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Sgrc.Configuration.Dto;

namespace Sgrc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SgrcAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
