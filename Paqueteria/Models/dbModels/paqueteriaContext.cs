using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Paqueteria.Models.dbModels
{
    public partial class paqueteriaContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public paqueteriaContext()
        {
        }

        public paqueteriaContext(DbContextOptions<paqueteriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estatus> Estatuses { get; set; }
        public virtual DbSet<Incidencia> Incidencias { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Repartidore> Repartidores { get; set; }
        public virtual DbSet<Vpedido> Vpedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasOne(d => d.MunicipioNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Municipio)
                    .HasConstraintName("FK_Users_Municipios");
            });

            modelBuilder.Entity<Incidencia>(entity =>
            {
                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Incidencia)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidencias_Pedidos");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedidos_Estatus");

                entity.HasOne(d => d.IdRepartidorNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdRepartidor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedidos_Repartidores");

                entity.HasOne(d => d.MunicipioNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.Municipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedidos_Municipios");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdVendedor)
                    .HasConstraintName("FK_Pedidos_Vendedores");
            });

            modelBuilder.Entity<Vpedido>(entity =>
            {
                entity.ToView("VPedidos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
