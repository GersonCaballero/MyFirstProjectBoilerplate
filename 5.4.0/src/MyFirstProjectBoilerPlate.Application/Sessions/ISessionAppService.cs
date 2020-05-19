using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstProjectBoilerPlate.Sessions.Dto;

namespace MyFirstProjectBoilerPlate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
