using System;

namespace Logical_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems \n ");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series \n 2. Perfect Number \n 3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter the number :");
                        Fibonacci series = new Fibonacci();
                        series.FibonacciS();
                        break;
                    case 2:
                        Console.Write("Enter the number :");
                        PerfectNumber number = new PerfectNumber();
                        number.Perfect();
                        break; ;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
