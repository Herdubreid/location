using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Data
{
    public class Address
    {
        public string addressLine { get; set; }
        public string adminDistrict { get; set; }
        public string countryRegion { get; set; }
        public string formattedAddress { get; set; }
        public string locality { get; set; }
        public string postalCode { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }
}
