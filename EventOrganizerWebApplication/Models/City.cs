using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class City
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Place> Places { get; set; } = new List<Place>();
}
