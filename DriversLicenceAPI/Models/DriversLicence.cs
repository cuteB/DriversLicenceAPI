using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversLicenceAPI.Models
{
    public class DriversLicence
    {
        
        public int Id { get; set; } = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string LicenceNumber { get; set; }
        public int LicenceClass { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province  { get; set; }
        public string PostalCode { get; set; }
        public string Sex { get; set; }
        public string EyeColour { get; set; }
        public string HairColour { get; set; }
        public int DobDay { get; set; }
        public int DobMonth { get; set; }
        public int DobYear { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int ExpiryDay { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }

        

    } 
}