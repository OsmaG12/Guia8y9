using Microsoft.EntityFrameworkCore;

namespace Guia_9.Models
{
    public class equiposDbContext : DbContext
    {

        public equiposDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<marcas> marcas { get; set; }
    }
}
