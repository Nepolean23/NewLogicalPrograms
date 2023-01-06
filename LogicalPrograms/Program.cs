
using LogicalPrograms;

Console.WriteLine("1.FibonnaciNumbers,2.PerfectNumbers");
Console.WriteLine("Enter your option to get in to above Programs:");
int option=Convert.ToInt32(Console.ReadLine());
switch(option)
{
    case 1:
        FibonacciSeries.Finonaccinumbers();
        break;

    case 2:
        PerfectNumber.Checkingperfectnumbers(); 
        break;



}