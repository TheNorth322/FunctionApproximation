using System;

namespace FunctionApproximation.Model
{
	public class LagrangePolynom
	{
		private Point<float>[] points;
		public LagrangePolynom(Point<float>[] _points) 
		{
			if (_points == null) throw new ArgumentNullException(nameof(points));
			points = _points; 
		}
		
		public float Calculate(float x)
		{
			float sum = 0;	
		    
			for (int i = 0; i < points.Length; i++) 
		    {
				float product = points[i].Y;

				for (int j = 0; j < points.Length; j++)
					product *= (i == j) ? 1 : (x - points[j].X) / (points[i].X - points[j].X);

				sum += product;
		    }

			return sum;
		}
		
	}
}
