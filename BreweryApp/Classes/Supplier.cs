﻿using System;
using System.Collections.Generic;

namespace BreweryApp.Classes;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? ContactFirstName { get; set; }

    public string? ContactLastName { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<IngredientInventoryAddition> IngredientInventoryAdditions { get; } = new List<IngredientInventoryAddition>();

    public virtual ICollection<SupplierAddress> SupplierAddresses { get; } = new List<SupplierAddress>();
}
