
using LogicalPrograms;

Console.WriteLine("1.FibonnaciNumbers,2.PerfectNumbers,3.PrimeNumbers,4.ReverseNumber,5.CouponNumbers,6.StopWatch");
Console.WriteLine("Enter your option to get in to above Programs:");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        FibonacciSeries.Finonaccinumbers();
        break;

    case 2:
        PerfectNumber.Checkingperfectnumbers();
        break;

    case 3:
        PrimeNumbers.Checkingprimenumbers();
        break;

    case 4:
        ReverseNumber.Checkingreversenumber();
        break;

    case 5:
       CouponNumbers.Generatingnumbers();
        break;

    case 6:
        StopWatch.TimeElapseing();
        break;



}