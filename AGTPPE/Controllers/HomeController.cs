using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGTPPE.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accueil()
        {

            return View();
        }

        public ActionResult Contact()
        {
          return View();
        }

        //[Authorize]
        public ActionResult Deconnexion()
        {
            return View();
        }
        public ActionResult User()
        {
            return View();
        }
        public ActionResult Administrateur()
        {
            return View();
        }
   
    }
}