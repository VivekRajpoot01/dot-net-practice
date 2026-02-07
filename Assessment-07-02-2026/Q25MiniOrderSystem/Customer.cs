using System;

namespace Q25MiniOrderSystem;

public class Customer
{
    public string custID { get; set; }
    public string Name { get; set; }

    public Customer(string cID, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ValidationException("Customer name is required");
        }
        
        custID = cID;
        Name = name;
    }
}
