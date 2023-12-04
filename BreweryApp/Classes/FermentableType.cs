using System;
using System.Collections.Generic;

namespace BreweryApp.Classes;

public partial class FermentableType
{
    public int FermentableTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Fermentable> Fermentables { get; } = new List<Fermentable>();
}
