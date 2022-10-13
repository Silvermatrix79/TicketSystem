using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using TicketServiceWebApi.Services.Interfaces;

namespace TicketServiceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly IDepartmentService _applicationService;

        public TestController(IDepartmentService applicationService)
        {
            _applicationService = applicationService;
        }



        [HttpGet]
        public async Task<List<Department>> GetAllApplications()
        {
            var applications = await _applicationService.GetAllApplications();
            return applications;
        }


    }
}
