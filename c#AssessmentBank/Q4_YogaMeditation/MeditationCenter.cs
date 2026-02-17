public class MeditationCenter
{
    public int MemberId { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string Goal { get; set; }
    public double BMI { get; set; }

    public void CalculateBMI()
    {
        double bmi = Weight / (Height * Height);
        BMI = Math.Floor(bmi * 100) / 100;
    }

    public int CalculateFee()
    {
        if (Goal.Equals("Weight Loss"))
        {
            if (BMI >= 25 && BMI < 30)
                return 2000;
            else if (BMI >= 30 && BMI < 35)
                return 2500;
            else if (BMI >= 35)
                return 3000;
            else
                return 0;
        }
        else if (Goal.Equals("Weight Gain", StringComparison.OrdinalIgnoreCase))
        {
            return 2500;
        }

        return 0;
    }
}
