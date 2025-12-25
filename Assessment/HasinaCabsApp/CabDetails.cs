using System;

namespace HasinaCabsApp;

public class CabDetails:Cab
{
    ///<summary>
    /// Method to validate the the booking id
    /// </summary>
    /// <returns>Validation (true/false)</returns>

    public bool ValidateBookingID()
    {
        if(BookingId.Length == 6 && BookingId.StartsWith("AC") && BookingId.IndexOf("@")==2 && int.TryParse(BookingId.Substring(3,3),out _))
        {
            return true;
        }
        return false;
    }

    public double CalculateFareAmount()
    {
        double waitingCharge = Math.Sqrt(WaitingTime);
        int cabPrice = 0;
        if(CabType == "HatchBack")
        {
            cabPrice = 10;
        }else if(CabType == "Sedan")
        {
            cabPrice = 20;
        }else if(CabType == "SUV")
        {
            cabPrice = 30;
        } 
        double Fare = (Distance *cabPrice) + waitingCharge;
        return Fare;
    }

     
}
