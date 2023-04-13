using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string destination { get; set; } 
        public string departure { get; set; } 
        public DateTime flightDate { get; set; } 
        public int flightId { get; set; }
        public DateTime effectiveArrival { get; set; } 
        public int estimatedDuration { get; set; } 
       // public List<Passenger> passengers { get; set; }
       public  virtual IList<ticket> Ticket { get; set; }

        public virtual  Plane ? plane { get; set; }   //prop Navigation foreign key t7outha fou9ha wala ta3ml kif haka
        [ForeignKey(nameof(plane))]
        public  int ? PlaneFK { get; set; }

        //public override string ToString()
        //{
        //    return destination + " " + departure + " " + flightDate + " " + effectiveArrival + " " + estimatedDuration 
        //        + " " + passengers + " " + plane;
        //}
    }
}
