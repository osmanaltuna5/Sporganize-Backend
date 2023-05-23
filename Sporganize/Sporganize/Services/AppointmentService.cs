using Sporganize.DTO;
using Sporganize.DTO.Responses;
using Sporganize.Repositories;

namespace Sporganize.Services
{
    public class AppointmentService : IAppointmentService
    {
        public readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public List<AppointmentResponse> GetAppointments()
        {
            List<AppointmentResponse> appointmentResponses= new List<AppointmentResponse>();
            foreach (var appointment in _appointmentRepository.GetAll())
            {
                appointmentResponses.Add(ConvertToDto.ToAppointmentResponse(appointment));
            }

            return appointmentResponses;
        }

    }
}
