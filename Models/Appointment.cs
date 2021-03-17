using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class Appointment
    {
        [Key] 
        [Required]
        public int AppointmentId { get; set; }  //primary key
        public TimeSlot? Time { get; set; }
        [Required]
        public int TimeSlotId { get; set; }     // foreign key references the TimeSlot class
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^([0-9]{3})[-]?([0-9]{3})[-]?([0-9]{4})$", ErrorMessage = "Enter phone in a valid format (##########)")]
        public string Phone { get; set; }       // phone is optional
    }
}
