using System;
using System.Collections.Generic;

namespace Project1.Models;

public partial class FlightDetailsView
{
    public int FlightId { get; set; }

    public string FlightNumber { get; set; } = null!;

    public DateTime DepartureTime { get; set; }

    public DateTime ArrivalTime { get; set; }

    public string DepartureAirport { get; set; } = null!;

    public string ArrivalAirport { get; set; } = null!;

    public string PilotName { get; set; } = null!;
}
