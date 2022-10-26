using Microsoft.EntityFrameworkCore;

namespace UsuarioEx.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)

        {
        }

        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Professores> Professores { get; set; }
    }
}