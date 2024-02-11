using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class EventsOrganizer
{
    public int OrganizerId { get; set; }

    public int EventId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdatedAt { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual User Organizer { get; set; } = null!;
}
