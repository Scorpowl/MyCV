using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyCV.Models.Entity;

namespace MyCV.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            MvcCvEntities db = new MvcCvEntities();
            var userinfo = db.TblAdmin.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);
            if(userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.KullaniciAdi, false);
                Session["KullaniciAdi"] = userinfo.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Deneyim");
            }
            else
            {
                ViewBag.Mesaj = "Hatalı Kullanıcı Adı veya Şifre";
                return RedirectToAction("Index", "Deneyim");
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Default");
        }
    }
}