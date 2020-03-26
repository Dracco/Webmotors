using Microsoft.EntityFrameworkCore;

namespace BD
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }

        public DbSet<Models.AnuncioWebmotors> tb_AnuncioWebmotors { get; set; }



        public void Dispose()
        {

        }
    }
}
