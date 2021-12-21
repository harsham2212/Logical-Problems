﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_problems
{
    class CouponNumber
    {
        public void Calculation(int N)
        {
            int count = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)

            {
                Random random = new Random();
                int Random_generate = random.Next(10, 100);
                count++;
                if (i == 0)
                {
                    array[i] = Random_generate;
                }
                else
                {
                    int j = 0;
                    int check = 0;
                    while (j < i)
                    {
                        if (array[j] == Random_generate)
                            check = 1;
                        j++;
                    }
                    if (check == 0)
                        array[i] = Random_generate;
                    else
                        i--;
                }
            }
            Console.WriteLine("Count value:"+count);
            Console.Write("Distinct Coupons Are:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}
