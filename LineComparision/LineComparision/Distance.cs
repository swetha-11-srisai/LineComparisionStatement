﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class Distance
    {
        double xOnePoint, xTwoPoint, yOnePoint, yTwoPoint;
        public Distance(double xOnePoint,double xTwoPoint,double yOnePoint,double yTwoPoint)
        {
            this.xOnePoint = xOnePoint;
            this.xTwoPoint = xTwoPoint;
            this.yOnePoint = yOnePoint;
            this.yTwoPoint = yTwoPoint;
        }
        public double CalculateLength()
        {
            double result = Math.Sqrt(Math.Pow(this.xTwoPoint - this.xOnePoint, 2)) + Math.Sqrt(Math.Pow(this.yTwoPoint - this.yOnePoint, 2));
            return result;
        }
        public void CheckGreater(double lengthone , double lengthtwo)
        {
            if(lengthone > lengthtwo)
            {
                Console.WriteLine("The second line is lesser than first line");
            }
            else if(lengthone < lengthtwo)
            {
                Console.WriteLine("The second line is greater than first line");
            }
            else
            {
                Console.WriteLine("Two lines length are not equal");
            }

        }

    }
}
