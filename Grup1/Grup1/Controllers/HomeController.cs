using Grup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grup1.Controllers
{
    public class HomeController : Controller
    {
        sinavdbEntities db = new sinavdbEntities();       

        // GET: Home
        public ActionResult Index()
        {
            Urunler urunler = new Urunler();
            urunler.urunlerList = db.Urunler_Tablosu.ToList();


            urunler.kategoriList = db.Kategori_Tablosu.ToList();

            return View(urunler);

        }

    }
}