using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class EFToursRepository : IToursRepository
    {
        private ToursDbContext _context;

        public EFToursRepository(ToursDbContext context)
        {
            _context = context;
        }

        public IQueryable<TimeSlot> TimeSlots => _context.TimeSlots;
        public IQueryable<Appointment> Appointments => _context.Appointments;
    }
}
