﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppGCourries.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBGCourriesContext : DbContext
    {
        public DBGCourriesContext()
            : base("name=DBGCourriesContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arrivee> Arrivee { get; set; }
        public virtual DbSet<ArriveeDocs> ArriveeDocs { get; set; }
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Depart> Depart { get; set; }
        public virtual DbSet<DepartDocs> DepartDocs { get; set; }
        public virtual DbSet<Entites> Entites { get; set; }
        public virtual DbSet<TUsers> TUsers { get; set; }
    }
}