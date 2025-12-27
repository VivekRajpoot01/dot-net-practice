public class PatientBill
{
    #region Properties

    public string BillId { get; set; }

    public string PatientName {get; set; }

    public bool HasInsurance {get; set; }
    public decimal ConsultationFee {get; set; }
    public decimal LabCharges {get; set; }
    public decimal MedicineCharges {get; set; }
    public decimal GrossAmount {get; set; }
    public decimal DiscountAmount {get; set; }
    public decimal FinalPayable {get; set; }

    #endregion

    public static PatientBill LastBill = null;
    public static bool HasLastBill = false; 

    public void CreateBill()
    {
        Console.Write("Enter Bill Id: ");

        BillId = Console.ReadLine();

        if (BillId== null)
        {
            Console.Write("Bill Id is empty");
            return;
        }

        Console.Write("Enter Patient Name:");
        PatientName = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N): ");

        string insuranceInput = Console.ReadLine();
        HasInsurance = (insuranceInput.ToUpper() == "Y");

        Console.Write("Enter Consultation Fee: ");
        ConsultationFee = decimal.Parse(Console.ReadLine());
        if (ConsultationFee <= 0)
        {
            Console.Write("Consultation fee must be greater than 0");
            return;
        }

        Console.Write("Enter Lab Charges: ");
        LabCharges = decimal.Parse(Console.ReadLine());

        if (LabCharges <= 0)
        {
            Console.Write("Lab charges must be greater than 0");
            return;
        }

        Console.Write("Enter Medicine Charges: ");
        MedicineCharges = decimal.Parse(Console.ReadLine());

        if (MedicineCharges <= 0)
        {
            Console.Write("Medicine charges must be greater than 0");
            return;
        }

        ComputeBilling();

        LastBill = this;
        HasLastBill = true;

        Console.WriteLine("Bill created successfully.");

        Console.WriteLine($"Gross Amount: {GrossAmount}");

        Console.WriteLine($"Discount Amount: {DiscountAmount}");

        Console.WriteLine($"Final Payable: {FinalPayable}");
    }

    public void ComputeBilling()
    {
        GrossAmount = ConsultationFee+LabCharges+MedicineCharges;

        if (HasInsurance)
        {
            DiscountAmount = GrossAmount * 0.10m;
        }
        else
        {
            DiscountAmount = 0;
        }

        FinalPayable = GrossAmount - DiscountAmount;
    }
    public static void PrintLastBill()
    {
        if (!HasLastBill || LastBill == null)
        {
            Console.WriteLine("No bill available. Please create new bill first.");

            return;
        }

        var b = LastBill;
        Console.WriteLine("==================Last Bill=========================");

        Console.WriteLine($"BillId         : {b.BillId}");

        Console.WriteLine($"Patient        : {b.PatientName}");

        Console.WriteLine($"Insured        : {(b.HasInsurance ? "Yes" : "No")}");

        Console.WriteLine($"Consultation Fee: {b.ConsultationFee}");

        Console.WriteLine($"Lab Charges    : {b.LabCharges}");

        Console.WriteLine($"Medicine Charges: {b.MedicineCharges}");


        Console.WriteLine($"Gross Amount   : {b.GrossAmount}");

        Console.WriteLine($"Discount Amount: {b.DiscountAmount}");

        Console.WriteLine($"Final Payable  : {b.FinalPayable}");

        Console.WriteLine("=======================================");
    }
    public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
}


