using System;
class Task4_Loops
{
    static void Main()
    {
        Console.WriteLine("Please choose an operation.");
        while (true)
        {
            Console.WriteLine("1.Option 1");
            Console.WriteLine("2.Option 2");
            Console.WriteLine("3.Option 3");
            Console.WriteLine("4.Exit");

            Console.WriteLine("Please choose an option from the menu : ");
            int option = int.Parse(Console.ReadLine());
            if (option==4)
            {
                break;
            }
            Console.WriteLine("Your choice is option {0}", option);
            Console.ReadLine();

        }
    }
}

