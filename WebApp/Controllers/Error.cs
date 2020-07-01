using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TurkCRM.WebApp.Controllers
{
    public class Error : Controller
    {
        [Route("error/404")]
        public IActionResult Error404()
        {
            return View();
        }

        [Route("error/{code:int}")]
        public IActionResult ErrorCode(int code)
        {
            // handle different codes or just return the default error view
            return View();
        }
    }
}
