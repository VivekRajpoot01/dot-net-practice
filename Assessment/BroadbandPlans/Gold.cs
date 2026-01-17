using System;

namespace BroadbandPlans;

public class Gold: IBroadbandPlan
{
    private readonly bool _isSubscriptionValid;
    private readonly int _discountPercentage;
    private const int PlanAmount = 1500;

    public Gold(bool isSubscriptionValid, int discountPercentage)
    {
        if(discountPercentage<0 || discountPercentage > 30)
        {
            throw new ArgumentOutOfRangeException();
        }
        _isSubscriptionValid = isSubscriptionValid;
        _discountPercentage = discountPercentage;
                
    }

    public int GetBroadbandPlanAmount()
    {
        if (_isSubscriptionValid)
        {
            return (PlanAmount - PlanAmount*_discountPercentage/100);
        }
        return PlanAmount;
    }    

}
