using Grup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grup1.Controllers
{
    public class TarihceController : Controller
    {
        sinavdbEntities db = new sinavdbEntities();

        // GET: Tarihce
        public ActionResult Index()
        {
            Tarihce tarihce = new Tarihce();
            tarihce.tarihceList = db.Tarihce_Tablosu.ToList();
            tarihce.ozellikList = db.Ozellik_Tablosu.ToList();

            return View(tarihce);
        }
    }
}