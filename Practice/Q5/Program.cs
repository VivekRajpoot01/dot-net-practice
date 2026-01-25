using System;

public class Owner
{
    protected string ownerName;
}

public class Car : Owner
{
    internal double price;
    private string bodyStyle;

    public string BodyStyle
    {
        get { return bodyStyle; }
        set { bodyStyle = value; }
    }

    public bool ValidateBodyStyle(string bodyStyle)
    {
        if(bodyStyle == "SUV" || bodyStyle == "Sedan")
        {
            return true;
        }
        return false;
    }

    public double CalculatePrice()
    {
        double newPrice = 0;
        if(BodyStyle == "SUV")
        {
            newPrice = price*0.9;
        }else if(BodyStyle == "Sedan")
        {
            newPrice = price*0.75;
        }
        return newPrice;
    }

    public void SetOwnerName(string name)
    {
        // TODO: Access the protected field 'ownerName' from the parent class
        ownerName = name;
    }
    
    // Helper method to get owner name for printing (since field is protected)
    public string GetOwnerName()
    {
        return ownerName;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Implement Input logic and Method calls
        // Note: 'price' is internal, so you can access it directly like: carObj.price = ...


                
        Console.WriteLine("Enter the owner name:");
        string ownerName = Console.ReadLine();

        Console.WriteLine("Enter the body style:");
        string bodyStyle = Console.ReadLine();

        Console.WriteLine("Enter the price:");
        double price = double.Parse(Console.ReadLine());

        Car carObj = new Car();

        if (carObj.ValidateBodyStyle(bodyStyle))
        {
            carObj.SetOwnerName(ownerName);
            carObj.BodyStyle = bodyStyle;
            carObj.price = price;

            //Output
            Console.WriteLine($"The owner {carObj.GetOwnerName()} sells the {carObj.BodyStyle} type car for ${carObj.CalculatePrice()}");
        }
        else
        {
            Console.WriteLine("Invalid Car Type");
        }


    }
}