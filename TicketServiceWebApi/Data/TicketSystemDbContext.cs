using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace TicketServiceWebApi.Data
{
    public class TicketSystemDbContext : DbContext
    {

        public TicketSystemDbContext(DbContextOptions<TicketSystemDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; } 
        public DbSet<Project> Projects { get; set; }

        public DbSet<User> Members { get; set; }

    }
}
