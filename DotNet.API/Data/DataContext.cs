using DotNet.API.Modals;
using Microsoft.EntityFrameworkCore;

namespace DotNet.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Values> Value { get; set; }
    }
}