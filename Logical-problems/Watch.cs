using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Logical_problems
{
    class Watch
    {
            public void Calculate()
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(5);
                }
                sw.Stop();
                Console.WriteLine("The lepse time is:{0:hh\\:mm\\:ss}", sw.Elapsed);
            }
        }
}
