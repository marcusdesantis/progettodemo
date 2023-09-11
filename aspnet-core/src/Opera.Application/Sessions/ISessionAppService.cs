using System.Threading.Tasks;
using Abp.Application.Services;
using Opera.Sessions.Dto;

namespace Opera.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
