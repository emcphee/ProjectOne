using System;
using System.Collections.Generic;

namespace Project1.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public int NumFlights { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
