﻿using JMVMedica.DataAccess.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMVMedica.DataAccess.Contexto
{
    public class JMVContexto : DbContext
    {
        public JMVContexto()
            : base("name=JMVMedica")
        {
            Database.SetInitializer<JMVContexto>(null);
        }
        public DbSet<TipoFarmaco> TipoFarmacos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Visita> Visitas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Nombre Tablas y Llaves primarias
            modelBuilder.Entity<TipoFarmaco>().ToTable("TipoFarmacos")
                .HasKey(x => x.TipoFarmacoId);

            modelBuilder.Entity<Marca>().ToTable("Marcas")
                .HasKey(x => x.MarcaId);

            modelBuilder.Entity<Medicamento>().ToTable("Medicamentos")
                .HasKey(x => x.MedicamentoId);

            modelBuilder.Entity<Medico>().ToTable("Medicos")
                .HasKey(x => x.MedicoId);

            modelBuilder.Entity<Paciente>().ToTable("Pacientes")
                .HasKey(x => x.PacienteId);

            modelBuilder.Entity<Ubicacion>().ToTable("Ubicaciones")
                .HasKey(x => x.UbicacionId);

            modelBuilder.Entity<Visita>().ToTable("Visitas")
                .HasKey(x => x.VisitaId);
            #endregion
        }
    }
}
