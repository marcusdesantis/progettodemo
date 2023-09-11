using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Opera.Configuration.Dto;

namespace Opera.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OperaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
