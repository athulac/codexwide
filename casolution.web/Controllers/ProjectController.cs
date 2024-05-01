using Microsoft.AspNetCore.Mvc;

namespace Codexwide.Web.Controllers
{
    public class ProjectController : Controller
    {
        [Route("projects")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("projects/vu-meter")]
        public IActionResult VUMeter()
        {
            return View();
        }
    }
}
