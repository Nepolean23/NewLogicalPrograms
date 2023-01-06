using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void Checkingperfectnumbers()
        {
            int sum=0;
            Console.WriteLine("Perfect Numbers Program");
            Console.Write("Enter a Number to check Perfect Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            for (int i = 1; i<num; i++)
            {
                
                if(num%i==0)
                {
                    sum+=i;
                }
                
            }
            if(sum==temp)
            {
                Console.WriteLine("The given number is perfect number :"+num);

            }
            else
            {
                Console.WriteLine("The given number is not perfect number :"+num);
            }
        }

    }
}
