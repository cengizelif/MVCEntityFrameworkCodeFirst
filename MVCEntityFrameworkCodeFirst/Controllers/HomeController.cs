using MVCEntityFrameworkCodeFirst.Models;
using MVCEntityFrameworkCodeFirst.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEntityFrameworkCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            DatabaseContext db = new DatabaseContext();
           List<Kisiler> kisilistesi= db.Kisiler.ToList();

            HomepageViewModel model = new HomepageViewModel();
            model.Kisiler = kisilistesi;
            model.Adresler=db.Adresler.ToList();    

            return View(model);
        }
    }
}