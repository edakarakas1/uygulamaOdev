using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grup1.Models
{
    public class Urunler
    {
        public List<Urunler_Tablosu> urunlerList { get; set; }
        public Urunler_Tablosu urunler_Tablosu { get; set; }
        public List<Kategori_Tablosu> kategoriList { get; set; }
        public Kategori_Tablosu kategori_Tablosu { get; set; }
    }
}