using System;
using System.Collections.Generic;

class Loops
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Display numbers from 1 to n (0 for exit) ");
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());

            if (n==0)
            {
                break;
            }

            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

