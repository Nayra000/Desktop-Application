﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace market_managment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Market_ManagmentEntities3 : DbContext
    {
        public Market_ManagmentEntities3()
            : base("name=Market_ManagmentEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customertb> Customertbs { get; set; }
        public virtual DbSet<ProductTb> ProductTbs { get; set; }
        public virtual DbSet<Suppliertb> Suppliertbs { get; set; }
        public virtual DbSet<Usertb> Usertbs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}