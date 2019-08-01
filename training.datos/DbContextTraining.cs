using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using training.datos.Mapping.Almacen;
using training.entidades.Almacen;

namespace training.datos
{
    public class DbContextTraining : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbContextTraining(DbContextOptions<DbContextTraining> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
