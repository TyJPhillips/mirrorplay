﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mirror_Play
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mirrorplay : DbContext
    {
        public mirrorplay()
            : base("name=mirrorplay")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<usermeta> usermetas { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<videometa> videometas { get; set; }
        public virtual DbSet<video> videos { get; set; }
    }
}
