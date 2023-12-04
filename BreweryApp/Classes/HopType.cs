using System;
using System.Collections.Generic;

namespace BreweryApp.Classes;

public partial class HopType
{
    public int HopTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Hop> Hops { get; } = new List<Hop>();
}
