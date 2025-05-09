using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCV.Models.Entity;
using MyCV.Repositories;

namespace MyCV.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkında
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda t)
        {
            var hakkimda = repo.Find(x => x.ID == 1);
            hakkimda.Ad = t.Ad;
            hakkimda.Soyad = t.Soyad;
            hakkimda.Adres = t.Adres;
            hakkimda.Mail = t.Mail;
            hakkimda.Telefon = t.Telefon;
            hakkimda.Aciklama = t.Aciklama;
            hakkimda.Foto = t.Foto;
            repo.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }
    }
}