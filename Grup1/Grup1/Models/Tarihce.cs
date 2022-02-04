using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grup1.Models
{
    public class Tarihce
    {
        public List<Tarihce_Tablosu> tarihceList { get; set; }

        public List<Ozellik_Tablosu> ozellikList { get; set; }
    }
}