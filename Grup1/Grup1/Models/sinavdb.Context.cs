﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grup1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sinavdbEntities : DbContext
    {
        public sinavdbEntities()
            : base("name=sinavdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hakkimizda_Tablosu> Hakkimizda_Tablosu { get; set; }
        public virtual DbSet<İletisim_Tablosu> İletisim_Tablosu { get; set; }
        public virtual DbSet<Kategori_Tablosu> Kategori_Tablosu { get; set; }
        public virtual DbSet<Ozellik_Tablosu> Ozellik_Tablosu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tarihce_Tablosu> Tarihce_Tablosu { get; set; }
        public virtual DbSet<Urunler_Tablosu> Urunler_Tablosu { get; set; }
    }
}
