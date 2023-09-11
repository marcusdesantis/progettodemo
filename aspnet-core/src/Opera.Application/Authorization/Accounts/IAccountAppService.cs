using System.Threading.Tasks;
using Abp.Application.Services;
using Opera.Authorization.Accounts.Dto;

namespace Opera.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
