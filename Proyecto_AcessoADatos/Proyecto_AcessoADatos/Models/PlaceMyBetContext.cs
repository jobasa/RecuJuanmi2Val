using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class PlaceMyBetContext : DbContext
    {

            public DbSet<Apuestas> Apuestas { get; set; } //Taula
            public DbSet<cuenta> Cuentas { get; set; } //Taula
            public DbSet<Evento> Eventos { get; set; } //Taula
            public DbSet<Mercado> Mercados { get; set; } //Taula
            public DbSet<Usuario> Usuarios { get; set; } //Taula

            public PlaceMyBetContext()
            {
            }

            public PlaceMyBetContext(DbContextOptions options)
            : base(options)
            {
            }

            //Mètode de configuració
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql("Server=127.0.0.1;Port=3306;Database=myDB2;Uid=root;password='';SslMode=none");//màquina retos

                }
            }

            //Inserció inicial de dades
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Evento>().HasData(new Evento(1, "Valencia","Ajax"));
                modelBuilder.Entity<Apuestas>().HasData(new Apuestas(1,100,3,"Aouesta Over",1,1));
                modelBuilder.Entity<cuenta>().HasData(new cuenta(1, "4000001234567899", 100, "La Caixa",1));
                modelBuilder.Entity<Mercado>().HasData(new Mercado("LaLiga",2,2,1,3,3,1));
                modelBuilder.Entity<Usuario>().HasData(new Usuario(1,"Joan","Banyuls","jobanyuls@gmail.com", 20));
            }

    }
}