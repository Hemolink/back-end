using Hemolink.Models;
using Microsoft.EntityFrameworkCore;

namespace Hemolink.Data
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Sangue> sangues { get; set; }
        public DbSet<Doador> doador { get; set; }
        public DbSet<Agenda> agenda { get; set; }
        public DbSet<Questionario> questionario { get; set; }

    }
}
