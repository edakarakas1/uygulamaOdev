using Grup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grup1.Controllers
{
    public class İletisimController : Controller
    {
        sinavdbEntities db = new sinavdbEntities();

        // GET: İletisim

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(İletisim_Tablosu i)
        {
            db.Entry(i).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}