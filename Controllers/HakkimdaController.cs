using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCV.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkında
        public ActionResult Index()
        {
            return View();
        }
    }
}