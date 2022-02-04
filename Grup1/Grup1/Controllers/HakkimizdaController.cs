using Grup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grup1.Controllers
{
    public class HakkimizdaController : Controller
    {
        sinavdbEntities db = new sinavdbEntities();

        // GET: Hakkimizda
        public ActionResult Index()
        {
            Hakkimizda hakkimizda = new Hakkimizda();
            hakkimizda.hakkimizdaList = db.Hakkimizda_Tablosu.ToList();
            return View(hakkimizda);
        }
    }
}