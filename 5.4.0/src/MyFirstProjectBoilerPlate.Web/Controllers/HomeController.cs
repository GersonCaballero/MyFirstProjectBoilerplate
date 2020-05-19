using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyFirstProjectBoilerPlate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyFirstProjectBoilerPlateControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}