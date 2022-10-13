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

        public DbSet<ProjectPriority> ProjectPriorities { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<TicketAttachment> TicketAttachments { get; set; }

        public DbSet<TicketComment> TicketComments { get; set; }

        public DbSet<TicketHistory> TicketHistories { get; set; }

        public DbSet<TicketPriority> TicketPriorities { get; set; }

        public DbSet<TicketStatus> TicketStati { get; set; }

        public DbSet<TicketType> TicketTypes { get; set; }

        public DbSet<Notification> Notifications { get; set; }

    }
}
