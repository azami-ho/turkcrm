using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebApp.Models;

namespace TurkCRM.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nav(string text)

        {
            //if (text == "favicon.ico") return null;
            //if (string.IsNullOrEmpty(text))
            //{
            //    RadynInvokeActionModel result = this.RadynRenderActionInvoke("/Reservation/Reserve/Index");
            //    if (result != null)
            //    {
            //        ViewBag.Html = result.Html;
            //        return View();
            //    }
            //    return View();
            //}
            //else
            //{
            //    string url = string.Empty;
            //    switch (text.ToLower())
            //    {
            //        case "admin":
            //            return Redirect("/Security/User/Login");
            //            break;
            //        default:
            //            url = RouteConfig.GetSuiteRoute(text);
            //            break;
            //    }
            //    RadynInvokeActionModel result = this.RadynRenderActionInvoke(url);
            //    if (result != null)
            //    {
            //        ViewBag.Html = result.Html;
            //        return View();
            //    }

               return View();
            //}
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
