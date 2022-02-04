using Grup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grup1.Controllers
{
    public class UrunController : Controller
    {
        sinavdbEntities db = new sinavdbEntities();

        //GET: Urun
        public ActionResult Detay(int id)
        {
            Urunler urunler = new Urunler();
            urunler.urunlerList = db.Urunler_Tablosu.ToList();

            urunler.urunler_Tablosu = db.Urunler_Tablosu.Find(id);

            urunler.kategoriList = db.Kategori_Tablosu.ToList();



            return View(urunler);
        }
    }
}