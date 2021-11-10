using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the line comparision ");
            Distance point = new Distance(9.0, 2.0, 7.0, 3.0);
            double lengthone = point.CalculateLength();
            Console.WriteLine("length of first line is:" + lengthone);
            Distance pointone = new Distance(8.0, 2.0, 7.0, 5.0);
            double lengthtwo = pointone.CalculateLength();
            Console.WriteLine("length of second line is:" + lengthtwo);
            point.CalculateLength();
            pointone.Equality(lengthone, lengthtwo);
        }
    }
}