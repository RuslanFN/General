using AppTeam101.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTeam101.Controllers
{
    public class HomeController : Controller
    {

        private DBContext db = new DBContext();
        public ActionResult Index(string first_name, string second_name)
        {
            ViewBag.NANA = first_name;
            ViewBag.TATA = second_name;

            var all = db.Events.ToList();
            var all2 = db.Events.ToList();
            all = db.Events.Where(a => a.first_name.Contains(first_name)).ToList();
            all2 = all.ToList().Where(a => a.second_name.Contains(second_name)).ToList();
            ViewBag.Vava = all2.ToList();
            return View(ViewBag.Vava);
        }

        //   [HttpGet]
        public ActionResult autor()
        {
            return View();
        }


    }
}