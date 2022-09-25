using Microsoft.EntityFrameworkCore;

namespace Tarjetas
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }
        public DbSet<Tarjeta> Tarjetas { get; set; }
    }
}
