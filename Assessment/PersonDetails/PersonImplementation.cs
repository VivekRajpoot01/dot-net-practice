using System;

namespace PersonDetails;

public class PersonImplementation
{
    public string GetName(IList<Person> person)
    {
        string getName = "";
        foreach(var pers in person)
        {
            getName += pers.Name + " " + pers.Address + " ";
        }

        return getName.Trim();
    }

    public double Average(IList<Person> person)
    {
        int sum = 0;
        int count = 0;

        foreach(var pers in person)
        {
            sum += pers.Age;
            count++;
        }
        return (double) sum/count;
    }

    public int Max(IList<Person> person)
    {
        int max = person[0].Age;

        foreach(var pers in person)
        {
            if (pers.Age > max)
            {
                max = pers.Age;
            }
        }

        return max;

    }
}
