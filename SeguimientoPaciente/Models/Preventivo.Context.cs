﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeguimientoPaciente.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FarmacosEntities : DbContext
    {
        public FarmacosEntities()
            : base("name=FarmacosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Examenes> Examenes { get; set; }
        public virtual DbSet<FarmacoExamen> FarmacoExamen { get; set; }
        public virtual DbSet<FarmacoPaciente> FarmacoPaciente { get; set; }
        public virtual DbSet<FarmacoReceta> FarmacoReceta { get; set; }
        public virtual DbSet<Farmacos> Farmacos { get; set; }
        public virtual DbSet<Historial> Historial { get; set; }
        public virtual DbSet<ItemsPreventivos> ItemsPreventivos { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<PermisosMenu> PermisosMenu { get; set; }
        public virtual DbSet<PermisosSubMenu> PermisosSubMenu { get; set; }
        public virtual DbSet<PreguntasItems> PreguntasItems { get; set; }
        public virtual DbSet<SubMenu> SubMenu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoDeSeguimiento> TipoDeSeguimiento { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}