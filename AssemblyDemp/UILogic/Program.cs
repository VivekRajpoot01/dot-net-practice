using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILogic
{
    [Doctor(Name = "Ravi Teja", CheckOnDate = "12/05/25")]
    [Doctor(Name = "Ramesh Londe", CheckOnDate = "18/03/25")]
    [Doctor(Name = "Bhagwan Das", CheckOnDate = "14/09/25")]
    [Serializable]
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            int numResult = logic.AddMe(num1, num2); 
            Console.WriteLine($"The sum of {num1} and {num2} is: {numResult}");

            Console.ReadKey();

        }
    }
}
