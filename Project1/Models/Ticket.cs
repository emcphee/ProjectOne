using System;
using System.Collections.Generic;

namespace Project1.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int FlightId { get; set; }

    public int CustomerId { get; set; }

    public DateTime BookingDate { get; set; }

    public decimal Price { get; set; }
}
