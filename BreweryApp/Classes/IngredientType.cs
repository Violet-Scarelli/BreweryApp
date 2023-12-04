using System;
using System.Collections.Generic;

namespace BreweryApp.Classes;

public partial class IngredientType
{
    public int IngredientTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ingredient> Ingredients { get; } = new List<Ingredient>();
}
