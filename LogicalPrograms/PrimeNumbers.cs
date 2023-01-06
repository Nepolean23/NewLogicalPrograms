using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumbers
    {
        public static void Checkingprimenumbers()
        {
            int divisior = 0;
            Console.WriteLine("Prime Numbers Programs");
            Console.Write("Enter a number to check Prime Number :");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int val = number % i;
                

                if (val == 0)
                {
                    divisior++;
                }
            }
            

            if(divisior==2)
            {
                Console.WriteLine("The given number is Prime number :"+number);

            }
            else
            {
                Console.WriteLine("The given number is not Prime number :" + number);
            }
        }
    }
}
