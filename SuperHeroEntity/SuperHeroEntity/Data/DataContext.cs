using Microsoft.EntityFrameworkCore;

namespace SuperHeroEntity.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<super> 
    }
}
