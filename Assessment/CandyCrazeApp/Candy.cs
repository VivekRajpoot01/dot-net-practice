using System;

namespace CandyCrazeApp;

public class Candy
{
    #region Properties
    public string Flavour { get; set; }

    public int Quantity { get; set; }

    public int PricePerPiece { get; set; }

    public double TotalPrice { get; set; }

    public double Discount { get; set; }

    #endregion

    public bool ValidateCandyFlavour()
    {
        if (Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
        {
            return true;
        }
        return false;
    }



}
