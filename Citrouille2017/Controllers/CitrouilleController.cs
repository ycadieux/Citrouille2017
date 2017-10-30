using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Citrouille2017.Controllers
{
    public class CitrouilleController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("admin")]
        public ActionResult Admin()
        {
            return View();
        }

        [Route("player/{device}")]
        public ActionResult Player(string device)
        {
            ViewBag.Device = device;

            return View();
        }
    }
}