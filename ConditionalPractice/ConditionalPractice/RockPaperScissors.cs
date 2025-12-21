using System;

namespace ConditionalPractice;

public class RockPaperScissors
{
    public static void Run()
    {
        Console.WriteLine("Enter 1, 2 and 3 choose choices for Player 1 and Player2");
        Console.WriteLine("------------------");

        Console.Write("Enter choice for Player 1");
        Console.Write("\n1. Rock\n2. Paper\n3. Scissors\n");
        int player1 = int.Parse(Console.ReadLine());

        if(player1<1 || player1 > 3)
        {
            Console.WriteLine("Enter Valid Input!");
            return;
        }

        Console.Write("Enter choice for Player 2");
        Console.Write("\n1. Rock\n2. Paper\n3. Scissors\n");
        int player2 = int.Parse(Console.ReadLine());

        if(player2<1 || player2 > 3)
        {
            Console.WriteLine("Enter Valid Input!");
            return;
        }


        if (player1 == player2)
        {
            Console.WriteLine("Draw!");
        }
        else
        {
            if (player1 == 1)
            {
                if (player2 == 2)
                {
                    Console.WriteLine("Player 2 Win!");
                }
                else
                {
                    Console.WriteLine("Player1 Win!");
                }
            }else if (player1 == 2)
            {
                if (player2 == 3)
                {
                    Console.WriteLine("Player 2 Win!");
                }
                else
                {
                    Console.WriteLine("Player 1 Win!");
                }
            }else if (player1 == 3)
            {
                if (player2 == 1)
                {
                    Console.WriteLine("Player 2 Win!");
                }
                else
                {
                    Console.WriteLine("Player 1 Win!");
                }
            }
        }

    }
}
