using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookingMvcClient.BookingServiceReference;

namespace BookingMvcClient.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            BookingClient client = new BookingClient();
            List<BookingData> bookings = 
                client.ViewBookingsFrom(DateTime.Now);
            return View(bookings);
        }

        [HttpGet]
        public ActionResult BookingForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookingForm(BookingData formData)
        {
            BookingClient client = new BookingClient();
            client.MakeBooking(formData);
            return RedirectToAction("Index");
        }
    }
}