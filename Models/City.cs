using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace RegCodeFirst.Models
{
    [Table("Cities", Schema = "Admin")]
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        [ForeignKey("State")]
        public int CityStateId { get; set; }
        public State  State { get; set; }
         public virtual List<State> GetStates { get; set; }
    }
}