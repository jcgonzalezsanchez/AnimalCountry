using HPWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace HPWebApp.Data
{
    public class HPContext : DbContext
    {
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PropietarioPaciente> PropietarioPacientes { get; set; }
        public HPContext(DbContextOptions<HPContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropietarioPaciente>().HasKey(x => new { x.PacienteId, x.PropietarioId});
        }
    }
}
