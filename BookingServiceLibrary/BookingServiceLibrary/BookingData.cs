using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookingServiceLibrary
{
    [DataContract]
    public class BookingData
    {
        [DataMember]
        public DateTime EventStartTime { get; set; }

        [DataMember]
        public DateTime EventStopTime { get; set; }

        //[DataMember]
        //public int BookingId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

}
