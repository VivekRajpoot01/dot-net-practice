using System;

namespace Q25MiniOrderSystem;

public class ValidationException: Exception
{
    public ValidationException(string msg): base(msg)
    {
        
    }

}

public class InvalidStockException: Exception
{
    public InvalidStockException(string msg): base(msg)
    {
        
    }
}
