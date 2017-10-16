using System;

class Task5_Loops
{
    static void Main()
    {
        Console.WriteLine("Guess a secret number.");
        Console.WriteLine("Player 1, please enter your number : ");
        int number = int.Parse(Console.ReadLine());
        Console.Clear();

        int numberoftries = 1;

        while (true)
        {
            Console.WriteLine("Player 2, please enter your guess : ");
            int guessnumber = int.Parse(Console.ReadLine());

            if (number == guessnumber)
            {
                Console.WriteLine("You win!!!");
                Console.WriteLine("Number of tries : {0}", numberoftries);
                break;
            }
            else
            {
                numberoftries++;

                if (number > guessnumber)
                {
                    Console.WriteLine("The number is bigger.");
                }
                else
                {
                    Console.WriteLine("The number is smaller.");
                }

            }

        }
    }
}
