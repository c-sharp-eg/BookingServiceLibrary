using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServiceLibrary
{
    public class BookingService : IBooking
    {
        private static IList<BookingData> bookings
            = new List<BookingData>();

        public bool MakeBooking(BookingData data)
        {
            // TODO: check if it's possible to make booking
            if (!CheckIfBookingIsPossible(data))
                return false;
            bookings.Add(data);
            return true;
        }
        private bool CheckIfBookingIsPossible(BookingData data)
        {
            Random r = new Random();
            if (r.Next() % 2 == 0)
                return true;
            return false;
        }

        public IList<BookingData> ViewBookingsFrom(DateTime when)
        {
            // TODO: only return bookings that happen after "when"
            return bookings;
        }
    }
}
