using core_proje_api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace core_proje_api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0NEP572;database=CoreProjeDB2;integrated security=true");
        }
        public DbSet<Category> Categories{ get; set; }
    }
}
