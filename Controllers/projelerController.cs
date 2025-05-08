using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCV.Models.Entity;
using MyCV.Repositories;

namespace MyCV.Controllers
{
    public class projelerController : Controller
    {
        // GET: projeler
        GenericRepository<TblHobilerim> repo = new GenericRepository<TblHobilerim>();
        public ActionResult Index()
        {
            var proje = repo.List();
            return View(proje);
        }
        [HttpGet]
        public ActionResult ProjeDüzenle(int id)
        {
            var proje = repo.Find(x => x.ID == id);
            return View(proje);
        }

        [HttpPost]
        public ActionResult ProjeDüzenle(TblHobilerim t)
        {
            var proje = repo.Find(x => x.ID == t.ID);
            proje.Baslik = t.Baslik;
            proje.Aciklama1= t.Aciklama1;
            proje.Etiket= t.Etiket;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

        public ActionResult ProjeSil(int id)
        {
            var proje = repo.Find(x => x.ID == id); // önce bul
            repo.TDelete(proje);                    // sonra sil
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ProjeEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProjeEkle(TblHobilerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
    
