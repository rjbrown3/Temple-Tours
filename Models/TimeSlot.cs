using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int TimeSlotId { get; set; }         //primary key
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public bool IsFull { get; set; } = false;   //determines whether time slot will appear on the sign up page
    }                                               //set to true when user submits sign up form
}
