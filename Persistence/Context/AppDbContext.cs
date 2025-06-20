using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<usuario> usuario { get; set; }
        public DbSet<viaje> viaje { get; set; }
        public DbSet<taxi> taxi { get; set; }
        public DbSet<detalleViaje> detalleViaje { get; set; }
        public DbSet<grupoUsuario> grupoUsuario { get; set; }
        public DbSet<grupoUsuarioDetalle> grupoUsuarioDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<usuario>()
                .HasKey(u => u.id);

            modelBuilder.Entity<grupoUsuario>()
                .HasKey(g => g.id);

            modelBuilder.Entity<grupoUsuario>()
                .HasOne(g => g.usuario)
                .WithMany(u => u.grupos)
                .HasForeignKey(g => g.idUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<grupoUsuarioDetalle>()
                .HasKey(gd => gd.id);

            modelBuilder.Entity<grupoUsuarioDetalle>()
                .HasOne(gd => gd.grupoUsuario)
                .WithMany(g => g.detalles)
                .HasForeignKey(gd => gd.idGrupoUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<viaje>()
                .HasKey(v => v.id);

            modelBuilder.Entity<viaje>()
                .HasOne(v => v.usuario)
                .WithMany(u => u.viajes)
                .HasForeignKey(v => v.idUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<taxi>()
                .HasKey(t => t.id);

            modelBuilder.Entity<taxi>()
                .HasOne(t => t.viaje)
                .WithOne(v => v.taxi)
                .HasForeignKey<taxi>(t => t.idViaje)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<detalleViaje>()
                .HasKey(d => d.id);

            modelBuilder.Entity<detalleViaje>()
                .HasOne(d => d.viaje)
                .WithMany(v => v.detalles)
                .HasForeignKey(d => d.idViaje)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
