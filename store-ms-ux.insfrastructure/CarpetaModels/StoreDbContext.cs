using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using store_ms_ux.domain.entities;

namespace store_ms_ux.insfrastructure.CarpetaModels
{
    public partial class StoreDbContext : DbContext
    {
        public StoreDbContext()
        {
        }

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<UsuarioDBContext> Usuarios { get; set; } = null!;

   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("categorias_pkey");

                entity.ToTable("categorias");

                entity.Property(e => e.Idcategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("idcategoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fechacreacion).HasColumnName("fechacreacion");

                entity.Property(e => e.Fechamodificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fechamodificacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("productos_pkey");

                entity.ToTable("productos");

                entity.Property(e => e.Idproducto)
                    .ValueGeneratedNever()
                    .HasColumnName("idproducto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fechacreacion).HasColumnName("fechacreacion");

                entity.Property(e => e.Fechamodificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fechamodificacion");
                entity.Property(e => e.Imagen)
                   .HasMaxLength(100)
                   .HasColumnName("imagen");

                entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasPrecision(10, 2)
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Idcategoria)
                    .HasConstraintName("productos_idcategoria_fkey");
            });

            modelBuilder.Entity<UsuarioDBContext>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("usuarios_pkey");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Email, "usuarios_email_key")
                    .IsUnique();

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("id_usuario");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
