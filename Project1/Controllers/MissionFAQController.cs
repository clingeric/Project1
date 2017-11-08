using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class MissionFAQController : Controller
    {
        // GET: MissionFAQ
        public ActionResult Index(string missionName)
        {
            ViewBag.missionName = missionName;
            return View();
        }
    }
}