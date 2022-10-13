using Microsoft.EntityFrameworkCore;
using Shared.Models;
using TicketServiceWebApi.Data;
using TicketServiceWebApi.Services.Interfaces;

namespace TicketServiceWebApi.Services
{
    public class DepartmentService : IDepartmentService
    {

        private readonly TicketSystemDbContext _context;

        public DepartmentService(TicketSystemDbContext ticketSystemDbContext)
        {
            this._context = ticketSystemDbContext;
        }

        public async Task<List<Department>> GetAllApplications()
        {
            var applications =await  _context.D.Include(r => r.Roles).ToListAsync();
            return applications;
        }




    }
}
