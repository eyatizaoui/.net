using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class ticket
    {
        public bool vip { get; set; }
        public double prix { get; set; }
        public string siege { get; set; }
        public  virtual Flight flight { get; set; }
        public  virtual Passenger passenger { get; set; }
       // [foreignkey(nameof(flight))]
        public int flightfk { get; set; } //lezem nafess type mte3 clé primaire eli houa fi passenger 
        //[foreignkey(nameof(passenger))]
        public string passengerfk { get; set; }
    }
}
