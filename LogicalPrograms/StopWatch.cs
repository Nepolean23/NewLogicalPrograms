using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalPrograms
{
    public class StopWatch
    {
        

        public static void TimeElapseing()
        {
            Console.WriteLine("Stop Watch Program");

            Stopwatch stopwatch= new Stopwatch();


            stopwatch.Start();
            Console.WriteLine("StopWatch started to run");

            for (int i=0;i<1000;i++) 
            {
                
                Thread.Sleep(2);
            }

            stopwatch.Stop();
            Console.WriteLine("Time elapsed:{0}", stopwatch.Elapsed);
            Console.WriteLine(Console.ReadKey()); 
        }
       

    }
}
        