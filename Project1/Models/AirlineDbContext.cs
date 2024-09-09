using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project1.Models;

public partial class AirlineDbContext : DbContext
{
    public AirlineDbContext()
    {
    }

    public AirlineDbContext(DbContextOptions<AirlineDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<FlightDetailsView> FlightDetailsViews { get; set; }

    public virtual DbSet<Pilot> Pilots { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-EN9FMHH\\SQLEXPRESS;Database=Project_One_DB;User=user;Password=password;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airport>(entity =>
        {
            entity.HasKey(e => e.AirportId).HasName("PK__Airports__C795D516A1509F2F");

            entity.HasIndex(e => e.AirportCode, "UQ__Airports__E949ADC7F5E5EC6B").IsUnique();

            entity.Property(e => e.AirportId).HasColumnName("airport_id");
            entity.Property(e => e.AirportCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("airport_code");
            entity.Property(e => e.AirportName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("airport_name");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("image_url");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__CD65CB85833C3019");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.NumFlights).HasColumnName("num_flights");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__Flights__E3705765B5D9E0AC");

            entity.ToTable(tb => tb.HasTrigger("UpdateNumberOfFlights"));

            entity.HasIndex(e => e.FlightNumber, "UQ__Flights__340D78BB707DE9B4").IsUnique();

            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.ArrivalAirportId).HasColumnName("arrival_airport_id");
            entity.Property(e => e.ArrivalTime)
                .HasColumnType("datetime")
                .HasColumnName("arrival_time");
            entity.Property(e => e.DepartureAirportId).HasColumnName("departure_airport_id");
            entity.Property(e => e.DepartureTime)
                .HasColumnType("datetime")
                .HasColumnName("departure_time");
            entity.Property(e => e.FlightNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("flight_number");
            entity.Property(e => e.PilotId).HasColumnName("pilot_id");
            entity.Property(e => e.RemainingSeats).HasColumnName("remaining_seats");

        });

        modelBuilder.Entity<FlightDetailsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlightDetailsView");

            entity.Property(e => e.ArrivalAirport)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("arrival_airport");
            entity.Property(e => e.ArrivalTime)
                .HasColumnType("datetime")
                .HasColumnName("arrival_time");
            entity.Property(e => e.DepartureAirport)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("departure_airport");
            entity.Property(e => e.DepartureTime)
                .HasColumnType("datetime")
                .HasColumnName("departure_time");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.FlightNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("flight_number");
            entity.Property(e => e.PilotName)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("pilot_name");
        });

        modelBuilder.Entity<Pilot>(entity =>
        {
            entity.HasKey(e => e.PilotId).HasName("PK__Pilots__FFF8AECE67286110");

            entity.HasIndex(e => e.LicenseNumber, "UQ__Pilots__D482A003F7C6A37F").IsUnique();

            entity.Property(e => e.PilotId).HasColumnName("pilot_id");
            entity.Property(e => e.ExperienceYears).HasColumnName("experience_years");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("license_number");
            entity.Property(e => e.NumberOfFlights).HasColumnName("number_of_flights");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Tickets__D596F96B533EAFB5");

            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("booking_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
