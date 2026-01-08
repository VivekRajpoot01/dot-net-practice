using System;

namespace RealStateListingMgmt;

public interface IRealEstateListing
{
    int ID {get; set; }
    string Title { get; set; }
    string Description { get; set; }
    int Price { get; set; }
    string Location {get; set; }
}
