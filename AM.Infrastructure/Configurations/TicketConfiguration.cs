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
    internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.passengerFk, t.FlightFk });
            builder.HasOne(p => p.passenger).WithMany(m =>m.Ticket).HasForeignKey(t => t.passengerFk);
             builder.HasOne(p => p.flight).WithMany(m =>m.Ticket).HasForeignKey(t => t.FlightFk);
             
           
        }
    }
}
