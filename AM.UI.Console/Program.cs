using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using System.Collections;
using System.Collections.Generic;
using static AM.ApplicationCore.Services.ServiceFlight;


// 7-
Plane plane = new Plane();
//plane.planeId = 1;
//plane.capacity = 500;
//plane.planeType = PlaneType.Airbus;
//plane.manufactureDate = new DateTime(2023, 05, 02);
//Un erreur se produit aprés la création d'un constructeur paramétrés

// 8- Création d'un constructeur

// 9-
//Plane plane2 = new Plane(PlaneType.Boing,480,new DateTime(2023, 04, 30));
//Un erreur se produit aprés la suppresion du constructeur crée au niveau de la question 8
//Plane plane3 = new Plane
//{
//    planeId = 1,
//    capacity = 1,
//    manufactureDate = new DateTime(2023, 04, 12),
//    planeType = PlaneType.Airbus
//};

// 10 - Création des méthode checkprofile();

// 11 -
//Passenger p = new Passenger();
//p.PassengerType();

//Staff s = new Staff();
//s.PassengerType();
//Traveller t = new Traveller();
//t.PassengerType();

// ------------------------------------------------------------------------
//TP2 
//5
 AMContext context = new AMContext();
//context.Flights.Add(new Flight() {destination="touness",departure="sfax",
  //  effectiveArrival= new DateTime(2021,2,1),
   // estimatedDuration=60,flightDate=new DateTime(2024,1,5),plane=new Plane() {capacity=140  ,manufactureDate=new DateTime(2023,3,1),planeType=PlaneType.Airbus }
//});
//context.SaveChanges();
foreach(var item in context.Flights.ToList())
{
    Console.WriteLine(item.flightId + " " + item.departure+" "+item.plane.capacity+" "+item.plane.manufactureDate);
}


//ServiceFlight serviceFlight = new ServiceFlight();
//serviceFlight.Flights = TestData.flights;

/*
serviceFlight.GetFlights("Paris",delegate(Flight f, String c)
{
    return f.destination == c;
});

serviceFlight.GetFlights("2023/01/01", (Flight f, String c) =>
{
    return f.flightDate.Equals(c);
});
*/

// Question 20 En Passenger Extension
//Passenger p = new Staff();
//p = TestData.staff[1];
//p.UpperFullName();
//Console.WriteLine(p.firstName + " " + p.lastName);