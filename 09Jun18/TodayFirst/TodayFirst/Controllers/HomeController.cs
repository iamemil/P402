using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodayFirst.Models;

namespace TodayFirst.Controllers
{
    public class HomeController : Controller
    {
        StudentContactEntities db = new StudentContactEntities();
        public ActionResult Index()
        {
            ViewHome data = new ViewHome();

            data.Students = db.Students.OrderByDescending(st => st.Id).ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}