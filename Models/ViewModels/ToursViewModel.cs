using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models.ViewModels
{
    public class ToursViewModel  //provides the view with the details of the tours to display on the page
    {
        public IEnumerable<TimeSlot> TimeSlots { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }
    }
}
