using SLAESolver;
using System;

namespace FunctionApproximation.Model
{
    public class InterpolationPolynom
    {
        private Point<float>[] points;
        private float[] coefficients;
        private PowerPolynom powerPolynom;
        
        public InterpolationPolynom(Point<float>[] _points)
        {
            if (_points == null)
                throw new ArgumentNullException(nameof(points));
            points = _points;
            coefficients = new float[points.Length];
            CalculateCoefficients();
            powerPolynom = new PowerPolynom(coefficients);
        }

        public float Calculate(float x) => powerPolynom.Calculate(x);

        private Matrix FillMatrix()
        {
            float[,] matrixCoefficients = new float[points.Length, points.Length + 1];

            for (int i = 0; i < points.Length; i++)
                for (int j = 0; j < points.Length + 1; j++)
                    matrixCoefficients[i, j] = j == points.Length
                        ? points[i].Y
                        : (float)Math.Pow(points[i].X, j);

            Matrix matrix = new Matrix(matrixCoefficients, points.Length, points.Length + 1);
            return matrix;
        }

        private void CalculateCoefficients()
        {
            Matrix matrix = FillMatrix();
            GaussMethod gaussMethod = new GaussMethod();
            coefficients = gaussMethod.Solve(matrix, true);
        }

    }
}
