using System;

namespace ProductInventoryMgmt;

public interface IProduct
{
    string Name { get; set; }
    string Category { get; set; }
    int Stock { get; set; }
    int Price { get; set; }
}
