﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stationeryapp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StationeryRetrievalFormDetailsDBContext : DbContext
    {
        public StationeryRetrievalFormDetailsDBContext()
            : base("name=StationeryRetrievalFormDetails")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<StationeryRetrievalFormDetail> StationeryRetrievalFormDetails { get; set; }
    }
}