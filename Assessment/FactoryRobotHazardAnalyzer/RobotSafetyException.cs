using System;

namespace FactoryRobotHazardAnalyzer;

public class RobotSafetyException: Exception
{
    public RobotSafetyException():base()
    {
        
    }

    public RobotSafetyException(string msg):base(msg)
    {
        
    }
}
