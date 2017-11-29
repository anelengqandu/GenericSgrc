using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Sgrc.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SgrcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}