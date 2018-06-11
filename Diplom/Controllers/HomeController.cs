using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        { 
            return View();
        }

        ProfilesContext db = new ProfilesContext();

        public ActionResult About()
        {
            //получаем из бд все объекты Profiles
            IEnumerable<Profiles> profiles = db.Profiles;
            //передаем все объекты в динамическое свойство Profiles в ViewBag
            ViewBag.Profile = profiles;
            //возвращаем представление
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}