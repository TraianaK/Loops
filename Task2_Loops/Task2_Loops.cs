using System;

class Task2_Loops
{
    static void Main()
    {
            int a = 1;
            while (a <= 10)
            {
                int b = 1;
                while (b <= 10)
                {
                    Console.WriteLine("{0}*{1} = {2}", b, a, a * b);
                    b++;
                }
                a++;
            }
    }
}

