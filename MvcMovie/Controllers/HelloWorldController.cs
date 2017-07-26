using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome
        // HttpServerUtility.HtmlEncode to protect from malicious input (Javascript)
        public ActionResult Welcome(string name = "Tresna", int NumTimes = 4)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = NumTimes;

            return View();
        }
    }
}