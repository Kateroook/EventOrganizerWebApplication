using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class Place
{
    public int Id { get; set; }

    public int PlaceTypeId { get; set; }

    public int CityId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? UnitNumber { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Zip { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual PlaceType PlaceType { get; set; } = null!;
}
