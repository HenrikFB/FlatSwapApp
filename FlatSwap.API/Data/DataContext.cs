using FlatSwap.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FlatSwap.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Value> Values { get; set; }
    }
}