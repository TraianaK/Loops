using System;

class MaxNumber
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var max = int.MinValue;

        for (int i = 1; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                num = max;
            }
        }
        Console.WriteLine("Max = " + max);
    }

}

