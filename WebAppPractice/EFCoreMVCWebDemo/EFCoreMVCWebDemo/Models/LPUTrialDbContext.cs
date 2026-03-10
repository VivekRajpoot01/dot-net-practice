using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EFCoreMVCWebDemo.Models
{
    public class LPUTrialDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder opBldr)
        {
            opBldr.UseSqlServer("server=.\\sqlexpress; Trusted_Connection=True; Database=LpuTrialDb; TrustServerCertificate=true");
        }
    }
}
