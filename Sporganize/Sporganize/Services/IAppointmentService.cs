using Sporganize.DTO.Responses;

namespace Sporganize.Services
{
    public interface IAppointmentService
    {
        public List<AppointmentResponse> GetAppointments();

    }

}
