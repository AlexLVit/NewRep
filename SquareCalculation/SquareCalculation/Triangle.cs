using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SquareCalculation
{
	public class Triangle : IShape
	{
		private double _firstSide;

		private double _secondSide;

		private double _thirdSide;

		public Triangle(double firstSide, double secondSide, double thirdSide)
		{
			this._firstSide = firstSide;
			this._secondSide = secondSide;
			this._thirdSide = thirdSide;
			
		}

		public double Calculate()
		{
			Debug.Assert(_firstSide > 0 && _secondSide > 0 && _thirdSide > 0);

			Debug.Assert(_firstSide < double.MaxValue && _secondSide < double.MaxValue && _thirdSide < double.MaxValue);

			double perimeter = (_firstSide + _secondSide + _thirdSide) / 2;

			double square = Math.Sqrt(perimeter * (perimeter - _firstSide) * (perimeter - _secondSide) * (perimeter - _thirdSide));

		    return square;
		}
	}
}
