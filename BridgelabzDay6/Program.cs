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
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.Pnumber();
                    break;
                case 3:
                    PrimeNumber number = new PrimeNumber();
                    number.Pnumber();
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

class PerfectNumber
{
    public void Pnumber()
    {
        int startingNumber, endingNumbeer;
        Console.WriteLine("Get All Perfect In Range of Between two Number");
        Console.Write("Enter Starting Number : ");
        startingNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter Ending Number : ");
        endingNumbeer = int.Parse(Console.ReadLine());

        Console.WriteLine("Below are the perfect number between " + startingNumber + " and " + endingNumbeer);

        for (int i = startingNumber; i <= endingNumbeer; i++)
        {
            decimal sum = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                    sum = sum + j;
            }
            if (sum == i)
                Console.WriteLine("\t" + i);
        }

      
    }
  
}


class PrimeNumber
{
    public void Pnumber()
    {
        Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = Check_Prime(number);
        if (result == 0)
        {
            Console.WriteLine("{0} is not a prime number", number);
        }
        else
        {
            Console.WriteLine("{0} is  a prime number", number);
        }
        Console.Read();
    }

    private static int Check_Prime(int number)
    {
        int i;
        for (i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
            {
                return 0;
            }
        }
        if (i == number)
        {
            return 1;
        }
        return 0;
    }
   
}
