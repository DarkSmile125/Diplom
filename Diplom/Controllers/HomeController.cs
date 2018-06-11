using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
        ProfileContext db = new ProfileContext();

        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult Profiles()
        {
            

            return View(db.Profiles.ToList());
        }
        
        

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}