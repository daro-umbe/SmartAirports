﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsSmartAirports
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class geartestEntities : DbContext
    {
        public geartestEntities()
            : base("name=geartestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Flights> Flights { get; set; }
        public virtual DbSet<PassengersInflights> PassengersInflights { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
    }
}
