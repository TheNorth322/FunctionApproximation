using SLAESolver;
using System;

namespace FunctionApproximation.Model
{
    public class SmoothingPolynom
    {
        private Point<float>[] points;
        public int Power { get; }
        private float[] coefficients;
        private PowerPolynom powerPolynom;

        public SmoothingPolynom(Point<float>[] _points, int _power) {
            if (_points== null) throw new ArgumentNullException(nameof(points));
            coefficients = new float[_power + 1];
            points = _points;
            Power = _power;
            CalculateCoefficients();
            powerPolynom= new PowerPolynom(coefficients);
        }
        
        public float Calculate(float x) => powerPolynom.Calculate(x);
        
        private void CalculateCoefficients()
        {
            float[,] coefficientMatrix = new float[Power + 1, Power + 2];

            FillCoefficientMatrix(coefficientMatrix, Power + 1, Power + 2);
            Matrix matrix = new Matrix(coefficientMatrix, Power + 1, Power + 2);

            GaussMethod gaussMethod = new GaussMethod();
            coefficients = gaussMethod.Solve(matrix, true);
        }
        
        private void FillCoefficientMatrix(float[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++)
                {
                    if (j == cols - 1)
                        matrix[i, j] = CalculateD(i);
                    else
                        matrix[i, j] = CalculateC(i + j);
                } 
            }
        }
        private float CalculateC(int power)
        {
            float c = 0;

            for (int i = 0; i < points.Length; i++)
                c += (float) Math.Pow(points[i].X, power);
            
            return c;
        }

        private float CalculateD(int power)
        {
            float d = 0;

            for (int i = 0; i < points.Length; i++)
                d += points[i].Y * (float) Math.Pow(points[i].X, power);

            return d;
        }
    }
}
