using System;

namespace PrepareBill;

class PrepareBill
{
    private readonly IDictionary<CommodityCategory,double> _taxRates;

    public PrepareBill()
    {
        
        _taxRates = new Dictionary<CommodityCategory,double>();
       
        
    }

    public void SetTaxRates(CommodityCategory category, double taxRate)
    {
        if(!_taxRates.ContainsKey(category))
        {
            _taxRates.Add(category,taxRate);
        }
        
    }

    public double CalculateBillAmount(IList<Commodity> items)
    {
        double bill = 0;
        foreach(var item in items)
        {
            if (!_taxRates.ContainsKey(item.Category))
            {
                throw new ArgumentException("Tax rate not defined "); 
            }
            double tax = _taxRates[item.Category];
            double amount = item.CommodityPrice * item.CommodityQuantity;
            bill += amount + (amount*tax/100);
            
        }

        return bill;
    }
}
