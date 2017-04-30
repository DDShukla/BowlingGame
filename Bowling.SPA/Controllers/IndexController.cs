using System.Web.Mvc;

namespace Bowling.SPA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Bowling game";

            return View();
        }
    }
}
