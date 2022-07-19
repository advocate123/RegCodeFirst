using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegCodeFirst.Models
{
    [Table("Registrations", Schema = "Student")]

    public class Registration
    {
        [Key]
        public int RegId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [EmailAddress ]
        public string EMail { get; set; }

        [ForeignKey("City")] 
        public int RegCityId { get; set; }
        public City City { get; set; }
        public virtual List<City> GetCities { get; set; }
    }
}