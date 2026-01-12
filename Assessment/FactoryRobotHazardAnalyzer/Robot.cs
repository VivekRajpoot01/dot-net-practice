using System;

namespace FactoryRobotHazardAnalyzer;

public class Robot
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        double hazardRiskScore = 0;

        if(armPrecision<0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
        }

        if(workerDensity<1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }

        if(!(machineryState == "Worn" || machineryState == "Faulty" || machineryState == "Critical"))
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }

        double machineryRiskFactor = 0;

        if(machineryState == "Worn")
        {
            machineryRiskFactor =1.3;
        }
        else if(machineryState == "Faulty")
        {
            machineryRiskFactor =2.0;
        }
        else if(machineryState == "Critical")
        {
            machineryRiskFactor =3.0;
        }


        hazardRiskScore = ((1.0-armPrecision)*15.0 +(workerDensity * machineryRiskFactor));
        return hazardRiskScore;
    }
}
