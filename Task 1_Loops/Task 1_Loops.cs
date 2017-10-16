using System;
class Task1_Loops
{
    static void Main()
    {
        Console.WriteLine("Display only even or odd numbers form n to 1. ");
        while (true)
        {
            Console.WriteLine("Please enter a number : ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                break;
            }
            while (n >= 1)
            {
                Console.WriteLine(n);
                n = n - 2;
            }
        }
    }
}

