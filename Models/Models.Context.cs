﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class INV_RIFEntities : DbContext
    {
        public INV_RIFEntities()
            : base("name=INV_RIFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Inv_Customer> Inv_Customer { get; set; }
        public virtual DbSet<Inv_OrderProduct> Inv_OrderProduct { get; set; }
        public virtual DbSet<Inv_Orders> Inv_Orders { get; set; }
        public virtual DbSet<Inv_Product> Inv_Product { get; set; }
        public virtual DbSet<Inv_ProductInventory> Inv_ProductInventory { get; set; }
        public virtual DbSet<Inv_ProductType> Inv_ProductType { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
