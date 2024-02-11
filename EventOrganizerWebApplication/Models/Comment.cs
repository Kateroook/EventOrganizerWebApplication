using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class Comment
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int EventId { get; set; }

    public string Text { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdatedAt { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
