using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Collections.Generic;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> bookings = new List<HotelBooking>();

        // Prikaz svih bookinga
        public IActionResult Index()
        {
            var bookings = new List<HotelBooking>(); // Privremena lista (umjesto baze)
            return View(bookings);
        }


        // Prikaz forme za unos novog bookinga
        public IActionResult Create()
        {
            return View();
        }

        // Dodavanje novog bookinga
        [HttpPost]
        public IActionResult CreateBooking(HotelBooking booking)
        {
            booking.Id = bookings.Count + 1; // Automatski ID
            bookings.Add(booking);
            return RedirectToAction("Index");
        }
    }
}


