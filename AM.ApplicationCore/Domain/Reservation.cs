using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Reservation
    {public DateTime DateReservation { get; set; }
        public  virtual Seat seat{ get; set; }
        public  virtual Passenger passenger { get; set; }
       // [ForeignKey(nameof(passenger))]   
       public  string PassengerFk { get; set; }
      //  [ForeignKey(nameof(seat))]
        public int SeatFk { get; set; }
    }
}
