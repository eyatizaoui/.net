using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public void DeletePlane()
        {
          // var l= GetAll().Where(p => (DateTime.Now - p.manufactureDate).TotalDays > 3650);   // where m3aha fonction lamda
                                                                                              //bch najem nfasa5 lezm nzid
           // foreach (var p in l)

           // {
            //    Delete(p);
             
           // Commit();      // commit hiya eli ta3ml sauvegarde fi base // diffrence entre date ya3tini bl totola melisecondes
         Delete(p => (DateTime.Now - p.manufactureDate).TotalDays > 3650);
           Commit ();
    }

        public IList<Flight> GetFlights(int n)
        {
            //  return GetAll().OrderBy(p=>p.planeId).TakeLast(n).SelectMany(p=>p.flights).OrderBy(p=>p.flightDate).ToList();
            return GetAll().OrderByDescending(p => p.planeId).Take(n).SelectMany(p => p.flights).OrderBy(p => p.flightDate).ToList();
        }

        public IList<Passenger> GetPassenger(Plane plane)
        {
            return plane.flights.SelectMany(p=>p.Ticket)
                .Select(t => t.passenger)
                .Distinct()
                .ToList();
        }
        public bool IsAvailablePlane(Flight f, int n)
        {
            // var plane = GetAll().Where(p => p.Flights.Contains(f) == true).First(); 
            var plane = Get(p => p.flights.Contains(f) == true); // toul nekhdem b Get taatini loula maghir .First ()
            var capacity = plane.capacity;
            //hashti ken bel vol atheka donc nlawej aalih (flight eli metaadya entre ()
            var flight = plane.flights.Single(j => j.flightId == f.flightId); // single khater metaakda besh trajaali element wahda 
            var ticket = flight.Ticket.Count();
            //condition capacite - ticket > n 
            return capacity - ticket > n;
        }
    }
}
