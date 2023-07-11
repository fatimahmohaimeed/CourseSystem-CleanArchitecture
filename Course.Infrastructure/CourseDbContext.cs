using Course.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Infrastructure
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many (Member and Rentals)
            modelBuilder.Entity<Member>()
                 .HasOne<Rental>(s => s.Rental)
                 .WithMany(r => r.Members)
                 .HasForeignKey(s => s.RentalId);

            //Many to Many (Rental and Course)
            modelBuilder.Entity<CourseRental>()
                .HasKey(g => new { g.RentalId, g.CourseId });

            //Handle Decimals to avoid precision loss

            modelBuilder.Entity<Rental>()
                .Property(p => p.TotalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Coursee>()
               .Property(p => p.RentalCost)
               .HasColumnType("decimal(18,2)");
        }
        public DbSet<Coursee> Courses { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<CourseRental> CourseRentals { get; set; }
    }
}
