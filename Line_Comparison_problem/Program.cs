using System;

namespace Line_Comparison_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first x1 co-ordinate point: ");
            double x1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first y1 co-ordinate point: ");
            double y1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first x2 co-ordinate point: ");
            double x2 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first y2 co-ordinate point: ");
            double y2 = (double)Convert.ToDecimal(Console.ReadLine());

            double length = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Length of the line is: " + length);
            Console.ReadKey();
        }
    }
}