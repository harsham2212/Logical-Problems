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
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibonacci series = new Fibonacci();
                        series.FibonacciS();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
