using System;

namespace CakeWorldApp;

public class Cake
{
    #region Properties
    public string Flavour {get; set;}

    public int QuantityInKg {get; set;}

    public double PricePerKg {get; set;}

    #endregion

    public bool CakeOrder()
    {
        if(Flavour != "chocolate" && Flavour != "red velvet" && Flavour != "vanilla")
        {
            throw new InvalidFlavourException("Flavour not available. Please select the available flavour (chocolate, red velvet or vanilla)");
        }
        

        if (QuantityInKg <= 0)
        {
            throw new NegativeQuantityException("Quantity must be greater than zero");
        }
        
        return true;
        
    }

    public double CalculatePrice()
    {
        double totalPrice = QuantityInKg * PricePerKg;
        double discount = 0;

        if(Flavour == "vanilla")
        {
            discount = 0.03;
        }else if(Flavour == "chocolate")
        {
            discount = 0.05;
        }else if(Flavour == "red velvet")
        {
            discount = 0.10;
        }

        double discountedPrice = totalPrice - (totalPrice*discount);
        return discountedPrice;
    }
}

public class InvalidFlavourException: Exception
{
    public InvalidFlavourException(string message): base(message)
    {
        
    }
}

public class NegativeQuantityException: Exception
{
    public NegativeQuantityException(string message): base(message)
    {
        
    }
}
