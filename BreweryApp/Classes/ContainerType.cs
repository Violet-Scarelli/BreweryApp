using System;
using System.Collections.Generic;

namespace BreweryApp.Classes;

public partial class ContainerType
{
    public int ContainerTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<BrewContainer> BrewContainers { get; } = new List<BrewContainer>();
}
