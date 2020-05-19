using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstProjectBoilerPlate.Configuration.Dto;

namespace MyFirstProjectBoilerPlate.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}