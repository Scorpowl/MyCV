using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCV.Models.Entity;
using MyCV.Repositories;

namespace MyCV.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<TblIletisim> repo = new GenericRepository<TblIletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}