﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTOs.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLSVEntities : DbContext
    {
        public QLSVEntities()
            : base("name=QLSVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DanhGia> DanhGias { get; set; }
        public virtual DbSet<DiaDanh> DiaDanhs { get; set; }
        public virtual DbSet<dichvu> dichvus { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<khachsan> khachsans { get; set; }
        public virtual DbSet<khuvuc> khuvucs { get; set; }
        public virtual DbSet<phong> phongs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}