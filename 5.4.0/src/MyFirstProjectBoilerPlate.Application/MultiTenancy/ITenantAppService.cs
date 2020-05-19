using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstProjectBoilerPlate.MultiTenancy.Dto;

namespace MyFirstProjectBoilerPlate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
