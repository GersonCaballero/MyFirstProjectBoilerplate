using Abp.AutoMapper;
using MyFirstProjectBoilerPlate.Sessions.Dto;

namespace MyFirstProjectBoilerPlate.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}