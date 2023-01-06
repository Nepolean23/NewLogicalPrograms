using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void Checkingreversenumber()
        {
            int reverseNumber=0,rem;
            Console.WriteLine("Reverse Number Program");
            Console.Write("Enter a number to check its Reverse Number :");
            int num=Convert.ToInt32(Console.ReadLine());
            while (num!=0)
            {
                rem = num % 10;
                reverseNumber = reverseNumber * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The Reversed Number is :"+reverseNumber);


        }
    }
}
