using System;

namespace PrepareBill;

public enum CommodityCategory
{
    Furniture,
    Grocery,
    Service
}
class Commodity
{
    public Commodity(CommodityCategory category, string commodityName, int commodityQuantity, double commodityPrice)
    {
        Category = category;
        CommodityName = commodityName;
        CommodityQuantity = commodityQuantity;
        CommodityPrice = commodityPrice;
    }

    public CommodityCategory Category { get; set; }
    public string CommodityName { get; set; }
    public int CommodityQuantity { get; set; }
    public double CommodityPrice {get; set; }


}
