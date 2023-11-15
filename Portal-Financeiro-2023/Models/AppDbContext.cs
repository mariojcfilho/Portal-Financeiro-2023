using Microsoft.EntityFrameworkCore;

namespace Portal_Financeiro_2023.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Despesa> Despesas { get; set; }
    }
}
