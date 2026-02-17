public class User
{
    public string Name {get; set;}
    public string Password {get; set;}
    public string ConfirmationPassword {get; set;}

    public static User ValidatePassword(string name, string password, string confirmationPassword)
    {
        if (password != confirmationPassword)
        {
            throw new PasswordMismatchException("Password entered does not Match");
        }

        return new User
        {
            Name = name,
            Password = password,
            ConfirmationPassword = confirmationPassword
        };
    }
}


public class PasswordMismatchException: Exception
{
    public PasswordMismatchException(string msg) : base(msg)
    {
        
    }
}