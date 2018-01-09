using System;

namespace MathLibrary
{
    public class Triangle
    {
        public static double GetArea(double sideA, double sideB, double sideC, double sigma = 0.0000001)
        {
            //checking parameters
            //Zero-lenght side check
            if(sideA < Math.Abs(sigma) || sideB < Math.Abs(sigma) || sideC < Math.Abs(sigma))
            {
                throw new Exception("Zero lenght side value!");
            }

            //check for triangle existence
            if(sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
            {
                throw new Exception("Triangle with given sides does not exist!");
            }

            //check for sigma value
            if(sigma < Math.Abs(0.0000000001))
            {
                throw new Exception("Sigma value is too low!");
            }

            //half of perimeter
            double p = (sideA + sideB + sideC) * 0.5;

            //area of triangle with given sides
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
