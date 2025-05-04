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
        
        GenericRepository<TblYeteneklerim> repo = new GenericRepository<TblYeteneklerim> ();

        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
    }
}