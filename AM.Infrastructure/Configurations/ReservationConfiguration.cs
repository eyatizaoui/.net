using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {

        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(c => new { c.PassengerFk, c.SeatFk, c.DateReservation });
            builder.HasOne(o=>o.passenger).WithMany(r=>r.Reservations).HasForeignKey(o=>o.PassengerFk);
            builder.HasOne(o => o.seat).WithMany(r => r.Reservations).HasForeignKey(o => o.SeatFk);
        } 
    }
}
