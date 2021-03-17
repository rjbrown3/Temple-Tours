using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)            //populate database with seed data
        {
            ToursDbContext context = application.ApplicationServices.CreateScope().
                ServiceProvider.GetRequiredService<ToursDbContext>();

            if (context.Database.GetPendingMigrations().Any())      //Make migrations when necessary
            {
                context.Database.Migrate();
            }

            if (!context.TimeSlots.Any())
            {
                context.TimeSlots.AddRange(

                    new TimeSlot
                    {
                        Date = DateTime.Parse("3/14/2021 08:00:00 AM")
                    },

                    new TimeSlot
                    {
                        Date = DateTime.Parse("3/14/2021 09:00:00 AM")
                    },

                    new TimeSlot
                    {
                        Date = DateTime.Parse("3/14/2021 10:00:00 AM")
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
