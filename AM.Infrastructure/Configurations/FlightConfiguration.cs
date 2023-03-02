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
    internal class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.flightId);
            builder.ToTable("MyFlight");
            builder.Property(j => j.departure).IsRequired().HasMaxLength(100).HasColumnName("ville de depart").HasDefaultValue("Tunis").HasColumnType("nchar");
            builder.HasOne(f => f.plane).WithMany(p => p.flights).HasForeignKey(f => f.PlaneFK).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(f => f.passengers).WithMany(f => f.flights).UsingEntity(p => p.ToTable("My Resevation"));
        }
    }
}
