using System;
using Microsoft.AspNetCore.Mvc;
using NetActionFilters.Models;

namespace NetActionFilters.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

