using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BookingServiceLibrary
{
    [ServiceContract]
    public interface BookingInterface
    {
        [OperationContract]
        bool MakeBooking(BookingData data);


    }


}
