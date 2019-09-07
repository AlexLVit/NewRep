using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SquareCalculation
{
	public class Circle : IShape
	{
		private double _radius;

		public Circle(double radius)
		{
			this._radius = radius;
		}

		public double Calculate()
		{
			Debug.Assert(_radius < double.MaxValue);

			double square = Math.PI * Math.Pow(_radius, 2);

			return square;
		}

	}

}
