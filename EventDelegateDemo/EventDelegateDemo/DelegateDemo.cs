using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegateDemo
{
    // Multicast Delegate
    public delegate void GreetMessage(string msg);

    //Unicast Delegate
    public delegate int Calculation(int num1, int num2); 

    class Hindi
    {
        public void WelcomeMsg(string username)
        {
            Console.WriteLine("Namaste!, " + username);
        }
    }
    class Tamil
    {

    }
    class Telegu
    {

    }
    class Malayalam
    {

    }
    class Bengali
    {

    }
    class Odiya
    {

    }
    class Punjabi
    {

    }
    class Marathi
    {

    }
    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            Hindi hObj = new Hindi();

            GreetMsg GreetInHindi = new GreetMsg(hObj.WelcomeMsg);

            GreetInHindi("Alok");
        }
    }
}
