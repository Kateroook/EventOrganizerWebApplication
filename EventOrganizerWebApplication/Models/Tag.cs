using System;
using System.Collections.Generic;

namespace EventOrganizerWebApplication.Models;

public partial class Tag
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }
}
