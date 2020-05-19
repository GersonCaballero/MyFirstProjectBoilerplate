using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstProjectBoilerPlate.Roles.Dto;
using MyFirstProjectBoilerPlate.Users.Dto;

namespace MyFirstProjectBoilerPlate.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}