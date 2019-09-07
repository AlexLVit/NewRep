using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SquareCalculation
{
	public class Circle : IShape
	{
		private double radius;

		public Circle(double _radius)
		{
			radius = _radius;
		}

		public double Calculate()
		{
			Debug.Assert(radius < double.MaxValue);

			double square = Math.PI * Math.Pow(radius, 2);

			return square;
		}

	}

}
