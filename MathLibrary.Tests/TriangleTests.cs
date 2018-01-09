using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_1_1_1_returned_0_4330127()
        {
            double sideA = 1;
            double sideB = 1;
            double sideC = 1;

            double sigma = 0.0000001;

            double expected = 0.4330127;

            double result = Triangle.GetArea(sideA, sideB, sideC);

            Assert.AreEqual(expected, result, sigma, "Triangle area with sides ({0};{1};{2}) should have been {3}!", sideA, sideB, sideC, expected);
        }

        [ExpectedException(typeof(Exception), "Exception \"Zero lenght side value!\" was not thrown!")]
        [TestMethod]
        public void GetArea_ZeroValuesInEachSideOneByOne_ExceptionTrown()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double sigma = 0.0000001;

            Triangle.GetArea(0, sideB, sideC);
            Triangle.GetArea(sideA, 0, sideC);
            Triangle.GetArea(sideA, sideB, 0);
        }

        [ExpectedException(typeof(Exception), "Exception \"Sigma value is too low!\" was not thrown!")]
        [TestMethod]
        public void GetArea_SigmaZeroValue_ExceptionTrown()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double sigma = 0;

            Triangle.GetArea(sideA, sideB, sideC, sigma);
        }
    }
}
