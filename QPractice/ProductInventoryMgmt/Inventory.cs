using System;

namespace ProductInventoryMgmt;

public class Inventory: IInventory
{
    private List<IProduct> _products;

    public Inventory()
    {
        _products = new List<IProduct>();  
    }
    
    public void AddProduct(IProduct product)
    {
        _products.Add(product);
    }


    public void RemoveProduct(IProduct product)
    {
        _products.Remove(product);
    }


    public int CalculateTotalValue()
    {
        int total = 0;
        foreach(var product in _products)
        {
            total += product.Price;
        }

        return total;
    }


    public List<IProduct> GetProductsByCategory(string category)
    {
        List<IProduct> categoryList = new List<IProduct>();

        foreach(var prod in _products)
        {
            if(prod.Category == category)
            {
                categoryList.Add(prod);
            }
        }

        return categoryList;
    }


    public List<(string, int)> GetProductsByCategoryWithCount()
    {
        Dictionary<string,int> res = new Dictionary<string,int>();

        foreach(var prod in _products)
        {
            string category = prod.Category;
            if (res.ContainsKey(category))
            {
                res[category] +=1;
            }
            res.Add(category,1);
        }

        List<(string,int)> output = new List<(string,int)>();

        foreach(var prod in res)
        {
            output.Add((prod.Key,prod.Value));
        }

        return output;
    }


    public List<IProduct> SearchProductsByName(string name)
    {
        List<IProduct> products = new List<IProduct>();

        foreach(var prod in _products)
        {
            if(prod.Name == name)
            {
                products.Add(prod);
            } 
        }

        return products;
    }


    public List<(string,List<IProduct>)> GetAllProductsByCategory()
    {
        Dictionary<string, List<IProduct>> map = new Dictionary<string, List<IProduct>>();

        foreach (var prod in _products)
        {
            string category = prod.Category;

            if (!map.ContainsKey(category))
            {
                map[category] = new List<IProduct>();
            }
            

            map[category].Add(prod);
        }

        List<(string, List<IProduct>)> result = new List<(string, List<IProduct>)>();

        foreach (var item in map)
        {
            result.Add((item.Key, item.Value));
        }
            

        return result;
    }
}
