using Microsoft.EntityFrameworkCore;
using Sporganize.Configurations;
using Sporganize.Generics;
using Sporganize.Models;

namespace Sporganize.Repositories
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        private readonly DataContext _dataContext;

        public AppointmentRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
        
        override
        public List<Appointment> GetAll()
        {
            return _dataContext.appointments.
                Include(a => a.Street).
                ThenInclude(s => s.District).
                ThenInclude(d => d.Province).
                ToList();
        }
    }

}
