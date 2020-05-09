using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS1_CisnerosAcostaJoseEnrique.Models
{
    public class EventDbContext: DbContext
    {
        public EventDbContext():base("CISNEROSDB")
        {

        }
        public DbSet <Event> Events { get; set; }
        public DbSet <City> Cities { get; set; }
    }
}