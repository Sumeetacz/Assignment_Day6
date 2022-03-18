using System;

namespace LogicalProblems_Day6
{
    class Brancher
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number to show the Result, \n");
            Console.WriteLine("1 for Fibonacci Series");
            Console.WriteLine("2 for Perfect Number");
            Console.WriteLine("3 for Prime Numer");
            Console.WriteLine("4 for Reverse a Number");
            Console.WriteLine("5 for Coupon Numbers");
            Console.WriteLine("6 for Simulate a Stopwatch Program \n");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Fab();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid Entry.");
                    break;
            }
        }
    }
}

class Fibonacci
{

    public void Fab()
    {
        int n, a = 0, b = 1, c, i;
        Console.Write("Enter the number of terms : ");
        n = Int32.Parse(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            if (i <= 1)
                c = i;
            else
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.Write(c + "  ");
        }
        Console.ReadKey();
    }
    
}

