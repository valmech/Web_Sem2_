using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebLab3.Models;

namespace WebLab3.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Clients> Clients => Set<Clients>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Objects> Objects => Set<Objects>();
        public DbSet<TypeHouses> TypeHouses => Set<TypeHouses>();
        public DbSet<Contract> Contracts => Set<Contract>();
    }
}
