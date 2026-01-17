using System;

namespace BroadbandPlans;

public class SubscribePlan
{
    private readonly IList<IBroadbandPlan> _broadbandPlans;

    public SubscribePlan(IList<IBroadbandPlan> broadbandPlans)
    {
        if(broadbandPlans == null)
        {
            throw new ArgumentNullException();
        }
        _broadbandPlans = broadbandPlans;
    }

    public IList<Tuple<string,int>> GetSubscriptionPlan()
    {

        IList<Tuple<string,int>> result = new List<Tuple<string,int>>();

        foreach(var plan in _broadbandPlans)
        {
            string planName = plan.GetType().Name;
            int price = plan.GetBroadbandPlanAmount();
            result.Add(new Tuple<string,int>(planName,price));
        }
        return result;
    }

}
