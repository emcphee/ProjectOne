using System;
using System.Collections.Generic;

namespace Project1.Models;

public partial class Pilot
{
    public int PilotId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string LicenseNumber { get; set; } = null!;

    public int ExperienceYears { get; set; }

    public int NumberOfFlights { get; set; }
}
