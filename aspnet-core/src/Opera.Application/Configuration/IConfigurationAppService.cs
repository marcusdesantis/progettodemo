using System.Threading.Tasks;
using Opera.Configuration.Dto;

namespace Opera.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
