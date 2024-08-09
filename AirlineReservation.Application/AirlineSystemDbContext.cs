using AirlineReservation.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Application
{
    public class AirlineSystemDbContext : DbContext
    {
        public AirlineSystemDbContext(DbContextOptions<AirlineSystemDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .HasKey(p => p.PaymentId);

            modelBuilder.Entity<Payment>()
                .HasKey(p => p.PaymentMethod);

            modelBuilder.Entity<Payment>()
                .Property(p => p.PaymentId);

        }
        public DbSet<Flight> Flights { get; set; }
    }
}
