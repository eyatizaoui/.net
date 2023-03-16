using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int passengerId { get; set; }
        [DisplayName("Date of Birth"),DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        [MinLength(3,ErrorMessage ="doit etre 3 caractére"), MaxLength(25,ErrorMessage ="longeur maximal 25")]


        // public string firstName { get; set; }
        // public string lastName { get; set; }
        public FullName FullName { get; set; } //zedna hethi
        [DataType(DataType.EmailAddress)] 
        public string emailAdress { get; set; }
       [RegularExpression("[0-9]{8}")]
        public string telNumber { get; set; }
        [Key]
        [MaxLength(7)]
        public string passportNumber { get; set; }
       // public List<Flight> flights { get; set; }
       public virtual List<Ticket> Ticket { get; set; }
        public virtual  List <Reservation> Reservations  { get; set; }
        //public override string ToString()
        //{
        //    return birthDate + " " + firstName + " " + lastName + " " +  emailAdress + " " + telNumber + " " + passportNumber + " " + flights;
        //}

        /*
        public bool CheckProfile(string fName, string lName)
        {
            return fName == firstName && lName == lastName;
        }
        public bool CheckProfile(string fName, string lName, string email)
        {
            return fName == firstName && lName == lastName && email == emailAdress;
        }
        */

        //public bool CheckProfile(string fName, string lName, string email=null)
        //{
        //    if (email==null)
        //        return fName == firstName && lName == lastName;

        //    return fName == firstName && lName == lastName && email == emailAdress;
        //}

        public virtual void PassengerType()
        {
            Console.WriteLine("I am passenger");
        }

    }
}
