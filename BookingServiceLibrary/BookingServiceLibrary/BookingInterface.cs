using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BookingServiceLibrary
{
    [ServiceContract]
    public interface IBooking
    {
        [OperationContract]
        bool MakeBooking(BookingData data);

        [OperationContract]
        IList<BookingData> ViewBookingsFrom(DateTime when);
    }


}
