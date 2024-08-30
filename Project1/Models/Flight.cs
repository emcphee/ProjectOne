using System;
using System.Collections.Generic;

namespace Project1.Models;

public partial class Flight
{
    public int FlightId { get; set; }

    public string FlightNumber { get; set; } = null!;

    public int DepartureAirportId { get; set; }

    public int ArrivalAirportId { get; set; }

    public DateTime DepartureTime { get; set; }

    public DateTime ArrivalTime { get; set; }

    public int PilotId { get; set; }

    public int RemainingSeats { get; set; }

    public virtual Airport ArrivalAirport { get; set; } = null!;

    public virtual Airport DepartureAirport { get; set; } = null!;

    public virtual Pilot Pilot { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
