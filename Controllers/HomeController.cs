using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;

// time slots for the Signup
// appointments for ViewAppointments
// SignUpForm

namespace TempleTours.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IToursRepository _repository;

        private ToursDbContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, IToursRepository repository, ToursDbContext cont)  
        {
            _repository = repository;
            _logger = logger;
            context = cont;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View(_repository.TimeSlots
                .Where(a => a.IsFull == false)  // return view with available time slots
                );
        }

        public IActionResult SignupForm(Appointment appoint)
        {
            if (ModelState.IsValid)
            {
                context.TimeSlots
                    .Where(t => t.TimeSlotId == appoint.TimeSlotId) 
                    .FirstOrDefault().IsFull = true;    // fill appointment (set IsFull to true)
                context.Appointments.Add(appoint);
                context.SaveChanges();

                return RedirectToAction("Index");   //redirect to the homepage
            }
            else
            {
                return View();
            }
        }

        public IActionResult GoToSignup(int timeslot)
        {
            ViewBag.Timeslot = timeslot;

            //ViewData["time"] = time;

            return View("SignupForm");
        }

        public IActionResult ViewAppointments()
        {
            IQueryable<Appointment> query = context.Appointments.Include(a => a.Time);
            var apt = query.ToList();
            return View(apt);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
