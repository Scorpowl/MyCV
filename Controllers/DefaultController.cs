using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using MyCV.Models.Entity;

namespace MyCV.Controllers
{
    public class DefaultController : Controller
    {
        MvcCvEntities db = new MvcCvEntities();
        // GET: Default
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitim()
        {
            var egitimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Projects()
        {
            var projeler = db.TblHobilerim.ToList();
            return PartialView(projeler);
        }
        public PartialViewResult Sertifikalarım()
        {
            var sertifikalar = db.TblSertifikalarim.ToList();
            return PartialView(sertifikalar);
        }
    }
}