using ASPNET_MVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_MVC.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
