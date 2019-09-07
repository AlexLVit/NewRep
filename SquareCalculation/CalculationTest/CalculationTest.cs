using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculation;
using System;

namespace CalculationTest
{
	[TestClass]
	public class CalculationTest
	{
		[TestMethod]
		public void TriangleSquarePossitiveTestMethod()
		{
			var newTriangle = new Triangle(3,4,5);
			var result = newTriangle.Calculate();

			Assert.AreEqual(result, 6);
		}

		[TestMethod]
		public void TriangleSquareNegativeTestMethod()
		{
			var newTriangle = new Triangle(3, 4, 5);
			var result = newTriangle.Calculate();

			Assert.AreNotEqual(result, 7);
		}

		[TestMethod]
		public void CircleSquarePossitiveTestMethod()
		{
			var newCircle = new Circle(2);
			double result = newCircle.Calculate();
			Assert.AreEqual(result, 12,5663706143592);
		}

		[TestMethod]
		public void CircleSquareNegativeTestMethod()
		{
			var newCircle = new Circle(2);
			double result = newCircle.Calculate();
			Assert.AreNotEqual(result, 13);
		}
	}
}
