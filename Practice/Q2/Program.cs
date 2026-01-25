using System;

public class Loan
{
    private string loanNumber;
    private string loanProviderName;
    private double loanAmount;

    public string LoanNumber
    {
        get { return loanNumber; }
        set { loanNumber = value; }
    }

    public string LoanProviderName
    {
        get { return loanProviderName; }
        set { loanProviderName = value; }
    }

    public double LoanAmount
    {
        get { return loanAmount; }
        set { loanAmount = value; }
    }
}

public class PersonalLoan : Loan
{
    private int numberOfYears;
    private float interestRate;

    public int NumberOfYears
    {
        get { return numberOfYears; }
        set { numberOfYears = value; }
    }

    public float InterestRate
    {
        get { return interestRate; }
        set { interestRate = value; }
    }

    public double CalculateEMI()
    {
        double emi = (LoanAmount + (LoanAmount * NumberOfYears * InterestRate * 0.01))/(NumberOfYears * 12 );
        return emi;
    }
}

public class HomeLoan : Loan
{
    private int houseAge;
    private float interestRate;

    public int HouseAge
    {
        get { return houseAge; }
        set { houseAge = value; }
    }

    public float InterestRate
    {
        get { return interestRate; }
        set { interestRate = value; }
    }

    public double CalculateEMI()
    {
        double emi = (LoanAmount+(LoanAmount*InterestRate*0.01))/(HouseAge*12);
        return emi;


    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Loan Number");
        string lNumber = Console.ReadLine();

        Console.WriteLine("Loan Provider Name");
        string lName = Console.ReadLine();

        Console.WriteLine("Loan Amount");
        double lAmount = double.Parse(Console.ReadLine());

        Console.WriteLine("1.Personal Loan\n2.Home Loan");

        int opt = int.Parse(Console.ReadLine());

        if (opt == 1)
        {
            PersonalLoan personalLoanObj = new PersonalLoan();

            personalLoanObj.LoanNumber = lNumber;
            personalLoanObj.LoanProviderName = lName;
            personalLoanObj.LoanAmount = lAmount;

            Console.WriteLine("Number of Years");
            personalLoanObj.NumberOfYears = int.Parse(Console.ReadLine());

            Console.WriteLine("Interest Rate");
            personalLoanObj.InterestRate = float.Parse(Console.ReadLine());

            AddLoan(personalLoanObj,opt);
        }else if (opt == 2)
        {
            HomeLoan homeLoanObj = new HomeLoan();

            homeLoanObj.LoanNumber = lNumber;
            homeLoanObj.LoanProviderName = lName;
            homeLoanObj.LoanAmount = lAmount;

            Console.WriteLine("House Age");
            homeLoanObj.HouseAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Interest Rate");
            homeLoanObj.InterestRate = float.Parse(Console.ReadLine());

            AddLoan(homeLoanObj,opt);
        }

        
    }

    public static void AddLoan(Loan loan, int opt)
    {
        double emi = 0;

        if(opt == 1)
        {
            PersonalLoan pl = (PersonalLoan)loan;
            Console.WriteLine($"Calculated EMI: {(int)pl.CalculateEMI()}");
            
        }else if(opt == 2)
        {
            HomeLoan hl = (HomeLoan)loan;
            Console.WriteLine($"Calculated EMI: {(int)hl.CalculateEMI()}");
        }
    }
}