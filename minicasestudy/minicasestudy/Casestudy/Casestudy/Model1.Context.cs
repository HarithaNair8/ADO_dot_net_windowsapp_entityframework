﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Casestudy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class foodEntities : DbContext
    {
        public foodEntities()
            : base("name=foodEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<fooditem> fooditems { get; set; }
        public virtual DbSet<restaurant> restaurants { get; set; }
        public virtual DbSet<userpassword> userpasswords { get; set; }
        public virtual DbSet<order_food> order_food { get; set; }
        public virtual DbSet<order_status> order_status { get; set; }
    }
}