using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_problems
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] arr = new int[10];
        public void Machine(int amount)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (amount >= notes[i])
                {
                    arr[i] = amount / notes[i];
                    amount = amount - (arr[i] * notes[i]);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + arr[i]);
                }
            }
        }
    }
}
