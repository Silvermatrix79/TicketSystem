

using Shared.Models;

namespace TicketServiceWebApi.Services.Interfaces
{
    public interface IDepartmentService
    {

        Task<List<Department>> GetAllApplications();



    }
}
