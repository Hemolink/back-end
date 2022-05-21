using Microsoft.EntityFrameworkCore;

namespace Hemolink.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Sangue> Sangues { get; set; }
    }
}
