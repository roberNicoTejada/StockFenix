//2
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using System.Data.SqlClient;

namespace LeerData
{
    
    public class AppVentaLibrosContext : DbContext
    {
        
        private const string connectionString = @"Data Source=DESKTOP-5GM2LA6\SQLEXPRESS01; Initial Catalog=LibrosWeb; Integrated Security=True";
       
        //Creo la config para crear la instancia de conexion a la BD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //Cuando tenemos mas de una PK en una entidad
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        
        {
            modelBuilder.Entity<LibroAutor>().HasKey(xi=>new {xi.AutorId, xi.LibroId});
        }
        public DbSet<Libro> Libro {get;set;}

//(1)Convierte a la clase Precio como entidad///////////////
        public DbSet<Precio> Precio {get;set;}

        public DbSet<Comentario> Comentario {get;set;}
        public DbSet<Autor> Autor {get;set;}
        public DbSet<LibroAutor> LibroAutor {get;set;}
    }
}