﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eFastFood_API.Models
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class eFastFoodEntitie : DbContext
    {
        public eFastFoodEntitie()
            : base("name=eFastFoodEntitie")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Dobavljac> Dobavljac { get; set; }
        public virtual DbSet<GotoviProizvod> GotoviProizvod { get; set; }
        public virtual DbSet<GPProizvod> GPProizvod { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<MjernaJedinica> MjernaJedinica { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<NarudzbaStavka> NarudzbaStavka { get; set; }
        public virtual DbSet<Proizvod> Proizvod { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<Uposlenik> Uposlenik { get; set; }
        public virtual DbSet<Dostava> Dostava { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
    }
}
