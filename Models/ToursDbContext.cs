using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class ToursDbContext : DbContext         //context for the database
    {
        public ToursDbContext(DbContextOptions<ToursDbContext> options) : base(options)
        {

        }

        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
