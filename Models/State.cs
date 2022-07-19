using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegCodeFirst.Models
{
    [Table("States", Schema = "Admin")]

    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }

        [ForeignKey("Country")]
        public int StateCntId { get; set; }
        public Country Country { get; set; }
        public virtual List<Country> GetCountries { get; set; }
    }
}