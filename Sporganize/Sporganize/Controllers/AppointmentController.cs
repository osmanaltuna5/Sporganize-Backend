using Microsoft.AspNetCore.Mvc;
using Sporganize.DTO.Responses;
using Sporganize.Services;

namespace Sporganize.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {

        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("/appointments")]
        public List<AppointmentResponse> GetAppointments()
        {
            return _appointmentService.GetAppointments();
        }

    }

}
