using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS1_CisnerosAcostaJoseEnrique.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string nombreevento { get; set; } 
        public DateTime fechaevento { get; set; }
        public string artistas { get; set; }
        public string comida { get; set; }
        public City idCiudad { get; set; }
    }
}