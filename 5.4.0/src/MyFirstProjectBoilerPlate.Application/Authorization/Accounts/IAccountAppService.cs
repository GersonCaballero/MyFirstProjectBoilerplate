using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstProjectBoilerPlate.Authorization.Accounts.Dto;

namespace MyFirstProjectBoilerPlate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
