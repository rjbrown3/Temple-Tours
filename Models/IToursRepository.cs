using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public interface IToursRepository
    {
        IQueryable<TimeSlot> TimeSlots { get; }  //Can get an IQueryable list of appointments from the repository
        IQueryable<Appointment> Appointments { get; }
    }
}
