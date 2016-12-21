using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingTestConsole.BookingServiceReference;
using System.Net;

namespace BookingTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BookingClient client = new BookingClient();
            while (true)
            {
                try
                {
                    BookingData[] bookings =
                        client.ViewBookingsFrom(DateTime.Now);
                    Console.WriteLine("Det finns " + bookings.Length
                        + " bokningar");

                    BookingData data = new BookingData();
                    data.Name = Console.ReadLine();
                    data.EventStartTime = DateTime.Now;
                    data.EventStopTime = DateTime.Now;
                    bool result = client.MakeBooking(data);
                    if (result)
                        Console.WriteLine("Bokningen lyckades");
                    else
                        Console.WriteLine("Bokningen misslyckades");

                }
                catch (WebException we)
                {
                    Console.WriteLine("Tjänsten failade");
                    Console.ReadLine();
                }
            }
        }
    }
}
