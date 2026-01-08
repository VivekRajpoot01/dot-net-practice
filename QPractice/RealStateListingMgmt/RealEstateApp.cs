using System;

namespace RealStateListingMgmt;

public class RealEstateApp
{
    private List<IRealEstateListing> _listings;

    public RealEstateApp()
    {
        _listings = new List<IRealEstateListing>();
    }

    public void AddListing(IRealEstateListing listing)
    {
        _listings.Add(listing);
    }

    public void RemoveListing(int listingID)
    {
        var findListing = _listings.Find(f => f.ID == listingID);
        if(findListing != null)
        {
            _listings.Remove(findListing);
        }
        
    }

    public void UpdateListing(IRealEstateListing updateList)
    {
        var findListing = _listings.Find(f => f.ID == updateList.ID);

        if(findListing != null)
        {
            findListing.Title = updateList.Title;
            findListing.Price = updateList.Price;
            findListing.Location = updateList.Location;
            findListing.Description = updateList.Description;
        }
    }

    public List<IRealEstateListing> GetListings()
    {
        return new List<IRealEstateListing>(_listings);
    }

    public List<IRealEstateListing> GetListingsByLocation(string location)
    {
        var listingsByLocation = _listings.FindAll(f => f.Location ==location);
        return listingsByLocation;
    }

    public List<IRealEstateListing> GetListingsByPriceRange(int minPrice, int maxPrice)
    {
        var listingByPriceRange = _listings.FindAll(f => f.Price>=minPrice && f.Price<=maxPrice);
        return listingByPriceRange;
    }



}
