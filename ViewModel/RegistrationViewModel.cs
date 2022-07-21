using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegCodeFirst.Models;

namespace RegCodeFirst.ViewModel
{
    public class RegistrationViewModel
    {
        public int RegId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Country { get; set; }


    }
}