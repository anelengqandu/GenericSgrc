using System.Web.Mvc;

namespace Sgrc.Web.Controllers
{
    public class AboutController : SgrcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}