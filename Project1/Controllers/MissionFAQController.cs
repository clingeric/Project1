﻿using System;
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

            switch (missionName)
            {
                case "NYRM":
                    
                    break;
                default:
                    break;
            }

            return View();
        }
    }
}
/*
mission name
mission president’s name
mission address
language
climate
dominate religion
a flag or symbol for the mission.
*/