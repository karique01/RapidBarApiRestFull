﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class rapidbarEntities : DbContext
    {
        public rapidbarEntities()
            : base("name=rapidbarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bar_types> bar_types { get; set; }
        public virtual DbSet<bars> bars { get; set; }
        public virtual DbSet<credit_cards> credit_cards { get; set; }
        public virtual DbSet<customers> customers { get; set; }
        public virtual DbSet<employees> employees { get; set; }
        public virtual DbSet<managers> managers { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<products_by_order> products_by_order { get; set; }
        public virtual DbSet<products_type> products_type { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tips> tips { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
