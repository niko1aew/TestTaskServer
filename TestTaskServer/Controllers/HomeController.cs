using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTaskServer.Models;

namespace TestTaskServer.Controllers
{
    public class HomeController : Controller
    {
        BidContext bidContext = new BidContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
