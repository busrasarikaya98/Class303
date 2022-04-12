using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapsApi.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public string HotelName { get; set; }
        public string PhoneNumber { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }
}
