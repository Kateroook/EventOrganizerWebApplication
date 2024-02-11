using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class PlaceType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Place> Places { get; set; } = new List<Place>();
}
