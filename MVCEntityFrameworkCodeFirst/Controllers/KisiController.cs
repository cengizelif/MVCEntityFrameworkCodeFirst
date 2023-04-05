using MVCEntityFrameworkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEntityFrameworkCodeFirst.Controllers
{
    public class KisiController : Controller
    {
        // GET: Kisi
        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Kisiler kisi)
        {
            DatabaseContext db=new DatabaseContext();
            db.Kisiler.Add(kisi);
            int sonuc=db.SaveChanges();
            if(sonuc>0) 
            {
                ViewBag.mesaj = "Kişi kaydedilmiştir.";
                ViewBag.renk = "success";
            }
            else 
            {
                ViewBag.mesaj = "Kişi kaydedilememiştir.";
                ViewBag.renk = "danger";
            }    
            return View();
        }
    }
}