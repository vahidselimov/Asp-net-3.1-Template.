
using Microsoft.EntityFrameworkCore;
using Sabutaj.Models;


namespace Sabutaj.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Products> products { get; set; }
    }
  
}
