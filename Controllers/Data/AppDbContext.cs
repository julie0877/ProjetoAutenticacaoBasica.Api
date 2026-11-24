using Microsoft.EntityFrameworkCore;
using ProjetoAutenticacaoBasica.Api.Controllers.Models;

namespace ProjetoAutenticacaoBasica.Api.Controllers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Voo> Voos { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
    }
}
