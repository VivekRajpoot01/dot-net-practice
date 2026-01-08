// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace RealStateListingMgmt;

public class Program
{
    public static void Main()
    {
        RealEstateApp app = new RealEstateApp();
        while (true)
        {
            Console.WriteLine("=====================Real Estate Listing Management=====================");
            Console.WriteLine("1. Add Listing");
            Console.WriteLine("2. View All Listings");
            Console.WriteLine("3. Search by Location");
            Console.WriteLine("4. Search by Price Range");
            Console.WriteLine("5. Remove Listing");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    RealEstateListing listing = new RealEstateListing();

                    Console.Write("Enter ID: ");
                    listing.ID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Title: ");
                    listing.Title = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    listing.Price = int.Parse(Console.ReadLine());

                    Console.Write("Enter Description: ");
                    listing.Description = Console.ReadLine();

                    Console.Write("Location: ");
                    listing.Location = Console.ReadLine();

                    app.AddListing(listing);

                    break;

                case 2:
                    var allListing = app.GetListings();

                    DisplayListings(allListing);

                    break;

                case 3:
                    Console.WriteLine("Enter Location: ");
                    string location = Console.ReadLine();

                    var locationListing = app.GetListingsByLocation(location);
                    DisplayListings(locationListing);
                    break;

                case 4:
                    Console.Write("Enter min price: ");
                    int minPrice = int.Parse(Console.ReadLine());

                    Console.Write("Enter max price: ");
                    int maxPrice = int.Parse(Console.ReadLine());

                    var priceListing = app.GetListingsByPriceRange(minPrice,maxPrice);
                    DisplayListings(priceListing);

                    break;

                case 5:
                    Console.Write("Enter listing ID to remove: ");
                    int ID = int.Parse(Console.ReadLine());

                    app.RemoveListing(ID);
                    Console.WriteLine("Listing removed if ID exists."); 
                    break;
                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid Input. Try Again!");
                    break;                     
            }
        }
    }
    static void DisplayListings(List<IRealEstateListing> listings)
    {
        if (listings.Count == 0)
        {
            Console.WriteLine("No listings found. Please add first!");
            return;
        }

        foreach (var l in listings)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"ID: {l.ID}");
            Console.WriteLine($"Title: {l.Title}");
            Console.WriteLine($"Price: {l.Price}");
            Console.WriteLine($"Location: {l.Location}");
            Console.WriteLine($"Description: {l.Description}");
        }
    }
}