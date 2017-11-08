using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project1.DAL;
using Project1.Models;

namespace Project1.Controllers
{
    public class MissionController : Controller
    {
        private MissionsContext db = new MissionsContext();
        // GET: Mission
        public ActionResult Index()
        {
            var missions = db.Missions;
            return View(missions.ToList());
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mission mission = db.Missions.Find(id);
            if (mission == null)
            {
                return HttpNotFound();
            }
            return View(mission);
        }
    }
}