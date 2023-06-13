using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SistemaCarniceriaBD.Models
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Productos> Productos{ get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Proveedores> Proveedores{ get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Informes> Informes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Puedes agregar configuraciones adicionales aquí si es necesario
        }
    }
}

