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
    internal class TicketConfiguration : IEntityTypeConfiguration<ticket>
    {
        public void Configure(EntityTypeBuilder<ticket> builder)
        {
            builder.HasKey(t => new { t.passengerfk, t.flightfk });
            builder.HasOne(p => p.passenger).WithMany(m =>m.Ticket).HasForeignKey(t => t.passengerfk);
             builder.HasOne(p => p.flight).WithMany(m =>m.Ticket).HasForeignKey(t => t.flightfk);
             
           
        }
    }
}
