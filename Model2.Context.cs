﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAPM_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYBENXEEntities2 : DbContext
    {
        public QUANLYBENXEEntities2()
            : base("name=QUANLYBENXEEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BaoCao> BaoCao { get; set; }
        public DbSet<ChuNhaXe> ChuNhaXe { get; set; }
        public DbSet<LichSuVaoRa> LichSuVaoRa { get; set; }
        public DbSet<LichTrinh> LichTrinh { get; set; }
        public DbSet<LoaiXe> LoaiXe { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<TaiXe> TaiXe { get; set; }
        public DbSet<TheXe> TheXe { get; set; }
        public DbSet<XeCoDinh> XeCoDinh { get; set; }
        public DbSet<YeuCau> YeuCau { get; set; }
    }
}
