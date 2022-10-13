

using Shared.Models;

namespace TicketServiceWebApi.Services
{
    public interface IDepartmentService
    {

        Task<List<Department>> GetAllApplications();



    }
}
