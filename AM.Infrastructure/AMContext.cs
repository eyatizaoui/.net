using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Flight> Flights {get;set;}
        public DbSet<Passenger> Passengers {get;set;}
        public DbSet<Plane> Planes {get;set;}
      //  public DbSet<Staff> Staff {get;set;}
        public DbSet<Traveller> Travellers {get;set;}
       // public DbSet<Test2> test2s { get;set;}
       public DbSet<Seat> Seats { get;set;}
    public DbSet <Section> Sections { get;set;}
    public DbSet <Reservation> Reservations { get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source = (localDB)\MsSqlLocalDB; initial catalog = EyaTizaoui; Integrated Security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new FlightConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());//
           // modelBuilder.Entity<Passenger>().ToTable("Passengers");
            modelBuilder.Entity<Traveller>().ToTable("Travllers");//tpt
            modelBuilder.Entity<Staff>().ToTable("staffs");//tpt kol entité ta3melha table mte3ha)
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());   
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(120);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
           // configurationBuilder.Properties<Double>().HaveColumnType("real").HavePrecision(2,3);
           
        }
    }
}
