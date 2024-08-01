using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantProject.Models;

namespace RestaurantProject.DAL {
    public class RestaurantProjectContext : IdentityDbContext<IdentityUser> {
        public RestaurantProjectContext(DbContextOptions<RestaurantProjectContext> options) : base(options) { }

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Appetizer> Appetizers { get; set; }
        public DbSet<Entree> Entrees { get; set; }
        public DbSet<Desert> Deserts { get; set; }
        public DbSet<Drink> Drinks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            //Promotion Table
            modelBuilder.Entity<Promotion>()
                .HasKey(p => p.PromotionId);

            modelBuilder.Entity<Promotion>()
                .Property(p => p.Image)
                .IsRequired();

            modelBuilder.Entity<Promotion>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(500);

            modelBuilder.Entity<Promotion>()
                .Property(p => p.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Promotion>()
                .Property(p => p.Discount);

            modelBuilder.Entity<Promotion>()
                .Property(p => p.DateTime)
                .IsRequired();


            // Testimonial Table
            modelBuilder.Entity<Testimonial>()
                .HasKey(t => t.TestimonialId);

            modelBuilder.Entity<Testimonial>()
                .Property(t => t.Review)
                .IsRequired()
                .HasMaxLength(500);

            modelBuilder.Entity<Testimonial>()
                .Property(t => t.ChefImage)
                .HasMaxLength(500);

            modelBuilder.Entity<Testimonial>()
                .Property(t => t.ChefName)
                .IsRequired()
                .HasMaxLength(500);

            modelBuilder.Entity <Testimonial>()
                .Property(t => t.Rating);

            //Appetizers
            modelBuilder.Entity<Appetizer>()
                .HasKey(a => a.AppetizerId);

            modelBuilder.Entity<Appetizer>()
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(75);
            modelBuilder.Entity<Appetizer>()
                .Property(a => a.Price)
                .IsRequired();
            modelBuilder.Entity<Appetizer>()
                .Property(a => a.Description)
                .IsRequired()
                .HasMaxLength(300);

            //Entrees
            modelBuilder.Entity<Entree>()
                .HasKey(e => e.EntreeId);

            modelBuilder.Entity<Entree>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(75);
            modelBuilder.Entity<Entree>()
                .Property(e => e.Price)
                .IsRequired();
            modelBuilder.Entity<Entree>()
                .Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(300);

            //Deserts
            modelBuilder.Entity<Desert>()
                .HasKey(d => d.DesertId);

            modelBuilder.Entity<Desert>()
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(75);
            modelBuilder.Entity<Desert>()
                .Property(d => d.Price)
                .IsRequired();
            modelBuilder.Entity<Desert>()
                .Property(d => d.Description)
                .IsRequired()
                .HasMaxLength(300);

            //Drinks
            modelBuilder.Entity<Drink>()
                .HasKey(d => d.DrinkId);

            modelBuilder.Entity<Drink>()
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(75);
            modelBuilder.Entity<Drink>()
                .Property(d => d.Price)
                .IsRequired();
            modelBuilder.Entity<Drink>()
                .Property(d => d.Description)
                .IsRequired()
                .HasMaxLength(300);

            //Locations
            //modelBuilder.Entity<Location>()
             //   .HasKey(l => l.LocationId);

            modelBuilder.Entity<Location>()
                .Property(l => l.Image)
                .IsRequired();
            modelBuilder.Entity<Location>()
                .Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(750);
            modelBuilder.Entity<Location>()
                .Property(l => l.Address)
                .IsRequired()
                .HasMaxLength(100);

            //Reservations
            modelBuilder.Entity<Reservation>()
                .HasKey(r => r.ReservationId);

            modelBuilder.Entity<Reservation>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(75);
            modelBuilder.Entity<Reservation>()
                .Property(r => r.NumOfPeople)
                .IsRequired();
            modelBuilder.Entity<Reservation>()
                .Property(r => r.ReservationDateTime);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Location)
                .WithMany(e => e.Reservations)
                .HasForeignKey(r => r.LocationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Reservation_Location");
        }
    }
}
