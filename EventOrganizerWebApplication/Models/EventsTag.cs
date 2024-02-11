using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class EventsTag
{
    public int TagId { get; set; }

    public int EventId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdatedAt { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}
