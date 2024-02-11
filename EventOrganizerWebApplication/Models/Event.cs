using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class Event
{
    public int Id { get; set; }

    public int PlaceId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DateTimeStart { get; set; }

    public DateTime DateTimeEnd { get; set; }

    public double? Price { get; set; }

    public string? Capacity { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdatedAt { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Place Place { get; set; } = null!;

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
