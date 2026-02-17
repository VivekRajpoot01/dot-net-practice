public class User
{
    public string Name{get; set; }
    public string PhoneNumber {get; set;}


    public static User ValidatePhoneNumber(string name, string phoneNumber)
    {
        if(phoneNumber.Length == 10)
        {
            return new User
            {
                Name = name,
                PhoneNumber = phoneNumber
            };
        }
        else
        {
            throw new InvalidPhoneNumberException("Invalid phone number");
        }
    }
    
}

public class InvalidPhoneNumberException: Exception
{
    public InvalidPhoneNumberException(string msg): base(msg)
    {
        
    }
}