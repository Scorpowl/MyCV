using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCV.Repositories;
using MyCV.Models.Entity;

namespace MyCV.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek

        GenericRepository<TblYeteneklerim> repo = new GenericRepository<TblYeteneklerim>();

        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(TblYeteneklerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var yetenek = repo.Find(x => x.ID == id); // önce bul
            repo.TDelete(yetenek);                    // sonra sil
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekDüzenle(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDüzenle(TblYeteneklerim t)
        {
            var yetenek = repo.Find(x => x.ID == t.ID);
            yetenek.Yetenek = t.Yetenek;
            yetenek.Oran = t.Oran;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}