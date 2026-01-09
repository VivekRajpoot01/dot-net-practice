using System;

namespace ProductInventoryMgmt;

public interface IInventory
{
    void AddProduct(IProduct product);
    void RemoveProduct(IProduct product);
    int CalculateTotalValue();
    List<IProduct> GetProductsByCategory(string category);
    List<(string, int)> GetProductsByCategoryWithCount();
    List<IProduct> SearchProductsByName(string name);
    List<(string,List<IProduct>)> GetAllProductsByCategory(); 

}
