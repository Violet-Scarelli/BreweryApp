using System;
using System.Collections.Generic;

namespace BreweryApp.Classes;

public partial class AdjunctType
{
    public int AdjunctTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Adjunct> Adjuncts { get; } = new List<Adjunct>();
}
