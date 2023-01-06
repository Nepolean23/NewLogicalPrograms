using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Finonaccinumbers()
        {
            int sum, f1 = 0, f2 = 1;
            Console.WriteLine("Fibonacci Numbers Programs");
            Console.Write("Enter the nth term for fibonacci series :");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.Write("0 + 1");
            for(int i=0; i<=num; i++) 
            {
                sum = f1 + f2;
                f1 = f2;
                f2= sum;
                Console.Write(" + "+sum);
            }
        }
    }
}
