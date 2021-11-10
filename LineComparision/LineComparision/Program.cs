using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the line comparision ");
            Distance point = new Distance(9.0,2.0,7.0,3.0);
            point.CalculateLength();
            Console.ReadLine();
        }
    }
}
