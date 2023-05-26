using Microsoft.EntityFrameworkCore;

namespace ProyectoDAW.Models
{
    public class trabajosContext : DbContext
    {
        public trabajosContext(DbContextOptions<trabajosContext> options) : base(options)
        { }

        public DbSet<empresa> empresas { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
    }
}
