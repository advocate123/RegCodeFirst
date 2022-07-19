using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegCodeFirst.Models
{
    public class DatabaseContext: DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
    }
}