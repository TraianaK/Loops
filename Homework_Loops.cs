using System;

class Homework_Loops
{
    static void Main()
    {
        Console.WriteLine("Please enter a number X : ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number Y : ");
        int y = int.Parse(Console.ReadLine());

        if (x < y)
        {
            for (int i = x; i<=y; i++)
            Console.WriteLine(i);
        }
        else
        {
            for (int i = x; i >= y; i--)
                Console.WriteLine(i);
        }
    }
}

