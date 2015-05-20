#if DEBUG
namespace MvcApplication.Web.Controllers
{
    using System.Web.Mvc;

    public class MochaTestRunnerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
#endif
