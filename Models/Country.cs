using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegCodeFirst.Models
{
    [Table("Country", Schema = "Admin")]
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}