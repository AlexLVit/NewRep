using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SquareCalculation
{
	public class Triangle : IShape
	{
		private double firstSide;

		private double secondSide;

		private double thirdSide;

		public Triangle(double _firstSide, double _secondSide, double _thirdSide)
		{
			firstSide = _firstSide;
			secondSide = _secondSide;
			thirdSide = _thirdSide;
			
		}

		 public double Calculate()
		{
			Debug.Assert(firstSide > 0 && secondSide > 0 && thirdSide > 0);

			Debug.Assert(firstSide < double.MaxValue && secondSide < double.MaxValue && thirdSide < double.MaxValue);

			double perimeter = (firstSide + secondSide + thirdSide) / 2;

			double square = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));

			return square;
		}
	}
}
