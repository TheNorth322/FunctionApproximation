using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApproximation.Model
{
	public class NewtonPolynom
	{
		private Point<float>[] points;
		public NewtonPolynom(Point<float>[] _points) {
			if (_points == null)
				throw new ArgumentNullException(nameof(_points));
			points = _points; 
		}

		public float Calculate(float x)
		{
			float[,] matrix = new float[points.Length, points.Length];
			
			for (int j = 0; j < points.Length; j++)
				matrix[0, j] = points[j].Y;
			
			for (int i = 1; i < points.Length; i++)
				for (int j = 0; j < points.Length - i; j++)
					matrix[i, j] = (matrix[i - 1, j + 1] - matrix[i - 1, j]) 
						/ (points[i + j].X - points[j].X);

			float sum = matrix[0, 0];
			float terminate = 1;

			for (int i = 1; i < points.Length; i++)
			{
				terminate *= x - points[i - 1].X;
				sum += matrix[i, 0] * terminate;
			}

			return sum;
		} 
	}
}
