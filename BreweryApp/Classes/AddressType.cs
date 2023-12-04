using System;
using System.Collections.Generic;

namespace BreweryApp.Classes;

public partial class AddressType
{
    public int AddressTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<SupplierAddress> SupplierAddresses { get; } = new List<SupplierAddress>();
}
